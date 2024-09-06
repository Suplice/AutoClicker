namespace AutoClicker
{
    partial class KeyboardAutoClickerForm
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
            components = new System.ComponentModel.Container();
            SetKeyButton = new Button();
            ChosenKeyBox = new TextBox();
            ChosenKeyLabel = new Label();
            IntervalInputBox = new TextBox();
            IntervalInputLabel = new Label();
            StartStopButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            ReturnButton = new Button();
            SuspendLayout();
            // 
            // SetKeyButton
            // 
            SetKeyButton.Location = new Point(38, 162);
            SetKeyButton.Name = "SetKeyButton";
            SetKeyButton.Size = new Size(158, 54);
            SetKeyButton.TabIndex = 0;
            SetKeyButton.Text = "Change Key";
            SetKeyButton.UseVisualStyleBackColor = true;
            SetKeyButton.Click += SetKeyButton_Click;
            // 
            // ChosenKeyBox
            // 
            ChosenKeyBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ChosenKeyBox.Location = new Point(240, 162);
            ChosenKeyBox.Name = "ChosenKeyBox";
            ChosenKeyBox.Size = new Size(158, 54);
            ChosenKeyBox.TabIndex = 1;
            // 
            // ChosenKeyLabel
            // 
            ChosenKeyLabel.AutoSize = true;
            ChosenKeyLabel.Location = new Point(240, 144);
            ChosenKeyLabel.Name = "ChosenKeyLabel";
            ChosenKeyLabel.Size = new Size(69, 15);
            ChosenKeyLabel.TabIndex = 2;
            ChosenKeyLabel.Text = "Chosen Key";
            // 
            // IntervalInputBox
            // 
            IntervalInputBox.Location = new Point(240, 78);
            IntervalInputBox.Name = "IntervalInputBox";
            IntervalInputBox.Size = new Size(158, 23);
            IntervalInputBox.TabIndex = 3;
            // 
            // IntervalInputLabel
            // 
            IntervalInputLabel.AutoSize = true;
            IntervalInputLabel.Location = new Point(240, 60);
            IntervalInputLabel.Name = "IntervalInputLabel";
            IntervalInputLabel.Size = new Size(76, 15);
            IntervalInputLabel.TabIndex = 4;
            IntervalInputLabel.Text = "Interval (ms):";
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(38, 60);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(158, 41);
            StartStopButton.TabIndex = 5;
            StartStopButton.Text = "Start/Stop (F8)";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // ReturnButton
            // 
            ReturnButton.Location = new Point(171, 10);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(75, 23);
            ReturnButton.TabIndex = 6;
            ReturnButton.Text = "<- Return";
            ReturnButton.UseVisualStyleBackColor = true;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // KeyboardAutoClickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 245);
            Controls.Add(ReturnButton);
            Controls.Add(StartStopButton);
            Controls.Add(IntervalInputLabel);
            Controls.Add(IntervalInputBox);
            Controls.Add(ChosenKeyLabel);
            Controls.Add(ChosenKeyBox);
            Controls.Add(SetKeyButton);
            Name = "KeyboardAutoClickerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SetKeyButton;
        private TextBox ChosenKeyBox;
        private Label ChosenKeyLabel;
        private TextBox IntervalInputBox;
        private Label IntervalInputLabel;
        private Button StartStopButton;
        private System.Windows.Forms.Timer Timer;
        private Button ReturnButton;
    }
}