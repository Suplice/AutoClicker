namespace AutoClicker
{
    partial class MouseAutoClickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StartAutoClickButton = new Button();
            StopButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            IntervalTimeStamp = new TextBox();
            IntervalLabel = new Label();
            StatusLabel = new Label();
            MessageBox = new Label();
            SetMousePositionButton = new Button();
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // StartAutoClickButton
            // 
            StartAutoClickButton.Location = new Point(21, 147);
            StartAutoClickButton.Name = "StartAutoClickButton";
            StartAutoClickButton.Size = new Size(148, 41);
            StartAutoClickButton.TabIndex = 0;
            StartAutoClickButton.Text = "Start";
            StartAutoClickButton.UseVisualStyleBackColor = true;
            StartAutoClickButton.Click += StartAutoClickButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(259, 147);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(148, 41);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // IntervalTimeStamp
            // 
            IntervalTimeStamp.Location = new Point(59, 65);
            IntervalTimeStamp.Name = "IntervalTimeStamp";
            IntervalTimeStamp.Size = new Size(73, 23);
            IntervalTimeStamp.TabIndex = 2;
            // 
            // IntervalLabel
            // 
            IntervalLabel.AutoSize = true;
            IntervalLabel.Location = new Point(59, 47);
            IntervalLabel.Name = "IntervalLabel";
            IntervalLabel.Size = new Size(73, 15);
            IntervalLabel.TabIndex = 3;
            IntervalLabel.Text = "Interval (ms)";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(177, 202);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(73, 15);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Not Clicking";
            // 
            // MessageBox
            // 
            MessageBox.AutoSize = true;
            MessageBox.Location = new Point(59, 91);
            MessageBox.Name = "MessageBox";
            MessageBox.Size = new Size(0, 15);
            MessageBox.TabIndex = 5;
            // 
            // SetMousePositionButton
            // 
            SetMousePositionButton.Location = new Point(259, 54);
            SetMousePositionButton.Name = "SetMousePositionButton";
            SetMousePositionButton.Size = new Size(148, 42);
            SetMousePositionButton.TabIndex = 6;
            SetMousePositionButton.Text = "Select location";
            SetMousePositionButton.UseVisualStyleBackColor = true;
            SetMousePositionButton.Click += SetMousePositionButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(175, 12);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 7;
            ReturnButton.Text = " <- Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // MouseAutoClickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 226);
            Controls.Add(ReturnButton);
            Controls.Add(SetMousePositionButton);
            Controls.Add(MessageBox);
            Controls.Add(StatusLabel);
            Controls.Add(IntervalLabel);
            Controls.Add(IntervalTimeStamp);
            Controls.Add(StopButton);
            Controls.Add(StartAutoClickButton);
            Name = "MouseAutoClickerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartAutoClickButton;
        private Button StopButton;
        private System.Windows.Forms.Timer Timer;
        private TextBox IntervalTimeStamp;
        private Label IntervalLabel;
        private Label StatusLabel;
        private Label MessageBox;
        private Button SetMousePositionButton;
        private Button ReturnButton;
    }
}
