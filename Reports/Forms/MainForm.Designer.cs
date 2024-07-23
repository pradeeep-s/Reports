namespace Reports.Forms
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
            LogOut_Button = new Button();
            SuspendLayout();
            // 
            // LogOut_Button
            // 
            LogOut_Button.Location = new Point(708, 1);
            LogOut_Button.Name = "LogOut_Button";
            LogOut_Button.Size = new Size(94, 29);
            LogOut_Button.TabIndex = 0;
            LogOut_Button.Text = "LogOut";
            LogOut_Button.UseVisualStyleBackColor = true;
            LogOut_Button.Click += LogOut_Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOut_Button);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LogOut_Button;
    }
}