using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickClick
{
    public partial class QuickClick : Form
    {
        // 声明WindowsAPI
        [DllImport("User32")]
        public extern static void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);
        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);
        [DllImport("User32")]
        public extern static void GetCursorPos(out POINT p);
        [DllImport("User32")]
        public extern static UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, UInt32 fsModifiers, UInt32 vk);
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        public struct POINT
        {
            public int X;
            public int Y;
        }

        /// <summary>
        /// 鼠标按键的ASCLL码
        /// </summary>
        public enum MouseEventFlags       
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            Wheel = 0x0800,
            Absolute = 0x8000
        }

        Point cursorPosition = new Point(0, 0);
        int clickCount = 0;
        Thread controlThread;

        const int hotKeyF10 = 247696411;
        const int hotKeyF11 = 247696412;

        public QuickClick()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            RegisterHotKey(this.Handle, 247696411, 0, (UInt32)Keys.F10);
            RegisterHotKey(this.Handle, 247696412, 0, (UInt32)Keys.F11);
            init();
        }

        private void init()
        {
            enableBtn(1);
        }

        /// <summary>
        /// 开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlThread == null)
                {
                    controlThread = new Thread(new ThreadStart(threadRunFunction));
                    controlThread.Start();
                }
            }
            catch (Exception)
            {
                Application.DoEvents();
                throw;
            }

            enableBtn(0);
        }

        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlThread != null)
                {
                    controlThread.Abort();
                }
                controlThread = null;
            }
            catch (Exception)
            {
                Application.DoEvents();
                throw;
            }
            clickCount = 0;
            enableBtn(1);
        }

        /// <summary>
        /// 线程运行函数
        /// </summary>
        private void threadRunFunction()
        {
            // 区分鼠标和键盘
            if(radioButton_Click.Checked)
            {
                label1.Text = "鼠标点击";
                while (true)
                {
                    autoClick(cursorPosition.X, cursorPosition.Y);
                }
            }
            
            if(radioButton_Enter.Checked)
            {
                label1.Text = "键盘点击";
                while(true)
                {
                    autoKeyPress(Keys.Enter);
                }
            }
        }
        
        /// <summary>
        /// 自动回车
        /// </summary>
        private void autoKeyPress(Keys code)
        {
            try
            {
                clickCount++;
                clickCountLabel.Text = clickCount.ToString();

                keyboardDown(code);
                Thread.Sleep(Convert.ToInt32(delayInput.Text));
                keyboardUp(code);
                Thread.Sleep(Convert.ToInt32(delayInput.Text));
            }
            catch (Exception)
            {
                Application.DoEvents();
                throw;
            }
        }
        /// <summary>
        /// 键盘按下某键
        /// </summary>
        /// <param name="code">按键码</param>
        private void keyboardDown(Keys code)
        {
            keybd_event((Byte)code, 0x45, 0x1, (UIntPtr)0);
        }
        /// <summary>
        /// 键盘松开某键
        /// </summary>
        /// <param name="code"></param>
        private void keyboardUp(Keys code)
        {
            keybd_event((Byte)code, 0x45, 0x1 | 0x2, (UIntPtr)0);
        }
        /// <summary>
        /// 自动点击
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void autoClick(int x, int y)
        {
            try
            {
                clickCount++;
                clickCountLabel.Text = clickCount.ToString();

                mouse_event((int)(MouseEventFlags.LeftDown | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
                Thread.Sleep(Convert.ToInt32(delayInput.Text));
                mouse_event((int)(MouseEventFlags.LeftUp | MouseEventFlags.Absolute), 0, 0, 0, IntPtr.Zero);
                Thread.Sleep(Convert.ToInt32(delayInput.Text));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void enableBtn(int flag = 0)
        {
            if(flag == 1)
            {
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
                radioButton_Click.Enabled = radioButton_Enter.Enabled = true;
            }
            else
            {
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                radioButton_Click.Enabled = radioButton_Enter.Enabled = false;
            }
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit(object sender, FormClosedEventArgs e)
        {
            stopBtn.PerformClick();
        }

        /// <summary>
        /// 重写消息循环
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_HOTKEY = 0x0312;

            if(m.Msg == WM_HOTKEY && m.WParam.ToInt32() == hotKeyF10)
            {
                startBtn.PerformClick();
            }

            if(m.Msg == WM_HOTKEY && m.WParam.ToInt32() == hotKeyF11)
            {
                stopBtn.PerformClick();
            }
        }

        private void miniSizeClick(object sender, EventArgs e)
        {
            MessageBox.Show("miniSize");
        }
    }
}
