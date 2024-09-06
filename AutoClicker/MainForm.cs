using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void KeyboardClicker_Click(object sender, EventArgs e)
        {
            KeyboardAutoClickerForm keyboardAutoClickerForm = new KeyboardAutoClickerForm();
            keyboardAutoClickerForm.Show();
            this.Hide();
        }

        private void MouseClicker_Click(object sender, EventArgs e)
        {
            MouseAutoClickerForm mouseAutoClickerForm = new MouseAutoClickerForm();
            mouseAutoClickerForm.Show();
            this.Hide();
        }

    }
}
