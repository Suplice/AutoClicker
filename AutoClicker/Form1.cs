using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private const int MOD_NONE = 0x0000;
        private const int WM_HOTKEY = 0x0312;

        private const int HOTKEY_ID_START = 1;
        private const int HOTKEY_ID_END = 2;

        bool isClicking = false;

        private Point mouseClickPosition = Point.Empty;

        public Form1()
        {
            InitializeComponent();

            RegisterHotKey(this.Handle, HOTKEY_ID_START, MOD_NONE, (int)Keys.F3);
            RegisterHotKey(this.Handle, HOTKEY_ID_END, MOD_NONE, (int)Keys.F4);
        }

        private void mouseClick()
        {
            if(mouseClickPosition != Point.Empty)
            {
                SetCursorPos(mouseClickPosition.X, mouseClickPosition.Y);
            }

            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartAutoClickButton_Click(object sender, EventArgs e)
        {
            StartAutoClicker();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopAutoClicker();
        }


        private void StartAutoClicker()
        {
            if (!isClicking)
            {
                int interval = 0;
                if (int.TryParse(IntervalTimeStamp.Text, out interval) && interval > 0)
                {
                    MessageBox.Text = String.Empty;
                    Timer.Interval = interval;
                    isClicking = true;
                    Timer.Start();
                    StatusLabel.Text = "Clicking";
                }
                else
                {
                    MessageBox.Text = "Invalid Input";
                }
            }
        }

        private void StopAutoClicker()
        {
            isClicking = false;
            Timer.Stop();
            StatusLabel.Text = "Not Clicking";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mouseClick();
        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {

                int id = m.WParam.ToInt32();

                if (id == HOTKEY_ID_START)
                {
                    StartAutoClicker();
                }
                else if (id == HOTKEY_ID_END)
                {
                    StopAutoClicker();
                }
            }
            base.WndProc(ref m);
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_END);


            base.OnFormClosing(e);
        }

        private void SetMousePositionButton_Click(object sender, EventArgs e)
        {
            SetMousePositionButton.Text = "Click anywhere to select position";
            this.Hide();
            this.MouseClick += SetClickPosition;
        }

        private void SetClickPosition(object sender, MouseEventArgs e)
        {
            mouseClickPosition = e.Location;

            this.MouseClick -= SetClickPosition;
            this.Show();
            SetMousePositionButton.Text = "Select location";
        }


    }
}
