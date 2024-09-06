using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class KeyboardAutoClickerForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int MOD_NONE = 0x0000;
        private const int WM_HOTKEY = 0x0312;

        private const int HOTKEY_ID_TOGGLE_ON_OFF = 1;

        private bool isClicking = false;
        private Keys selectedKey;

        public KeyboardAutoClickerForm()
        {
            InitializeComponent();
            RegisterHotKeys();
        }



        private void RegisterHotKeys()
        {
            RegisterHotKey(this.Handle, HOTKEY_ID_TOGGLE_ON_OFF, MOD_NONE, (int)Keys.F8);
            
        }

        private void SetKeyButton_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += CaptureKeyPress;
        }

        private void CaptureKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                selectedKey = e.KeyCode;
                ChosenKeyLabel.Text = $"Selected Key: {ConvertKeyToChar(selectedKey)}";
                ChosenKeyBox.Text = $"{ConvertKeyToChar(selectedKey)}";
                this.KeyDown -= CaptureKeyPress;
            }
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (isClicking)
            {
                StopAutoClicker();
            }
            else
            {
                StartAutoClicker();
            }
        }

        private void StartAutoClicker()
        {
            if (int.TryParse(IntervalInputBox.Text, out int interval) && interval > 0)
            {
                Timer.Interval = interval;
                Timer.Start();
                isClicking = true;
            }
        }
        
        private void StopAutoClicker()
        {
            Timer.Stop();
            isClicking = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            doKeyboardClick();
        }

        private void doKeyboardClick()
        {
            if (selectedKey != Keys.None)
            {
                string keyToSend = ConvertKeyToChar(selectedKey);
                if (!string.IsNullOrEmpty(keyToSend))
                {
                    SendKeys.Send(keyToSend);
                }
            }
        }

        private string ConvertKeyToChar(Keys key)
        {
            if (key >= Keys.D0 && key <= Keys.D9)
            {
                return ((char)('0' + (key - Keys.D0))).ToString();
            }
            else if (key >= Keys.A && key <= Keys.Z)
            {
                return key.ToString().ToLower();
            }

            switch (key)
            {
                case Keys.Space:
                    return " ";
                case Keys.Enter:
                    return "{ENTER}";
                case Keys.Back:
                    return "{BACKSPACE}";
                case Keys.Tab:
                    return "{TAB}";
                case Keys.Escape:
                    return "{ESC}";
                case Keys.Delete:
                    return "{DEL}";
                case Keys.Up:
                    return "{UP}";
                case Keys.Down:
                    return "{DOWN}";
                case Keys.Left:
                    return "{LEFT}";
                case Keys.Right:
                    return "{RIGHT}";
                default:
                    return key.ToString();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = (int)m.WParam;

                if (id == HOTKEY_ID_TOGGLE_ON_OFF)
                {
                    if (isClicking)
                    {
                        StopAutoClicker();
                    }
                    else
                    {
                        StartAutoClicker();
                    }
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_TOGGLE_ON_OFF);
            base.OnFormClosing(e);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Show();
            }
            this.Close();
        }
    }
}