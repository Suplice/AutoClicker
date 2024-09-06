namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KeyboardClicker = new Button();
            MouseClicker = new Button();
            SuspendLayout();
            // 
            // KeyboardClicker
            // 
            KeyboardClicker.Location = new Point(28, 39);
            KeyboardClicker.Name = "KeyboardClicker";
            KeyboardClicker.Size = new Size(97, 33);
            KeyboardClicker.TabIndex = 0;
            KeyboardClicker.Text = "Key Clicker";
            KeyboardClicker.UseVisualStyleBackColor = true;
            KeyboardClicker.Click += KeyboardClicker_Click;
            // 
            // MouseClicker
            // 
            MouseClicker.Location = new Point(179, 39);
            MouseClicker.Name = "MouseClicker";
            MouseClicker.Size = new Size(92, 33);
            MouseClicker.TabIndex = 1;
            MouseClicker.Text = "Mouse Clicker";
            MouseClicker.UseVisualStyleBackColor = true;
            MouseClicker.Click += MouseClicker_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 113);
            Controls.Add(MouseClicker);
            Controls.Add(KeyboardClicker);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button KeyboardClicker;
        private Button MouseClicker;
    }
}