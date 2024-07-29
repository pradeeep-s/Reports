namespace Reports.Forms
{
    partial class LoginForm
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
            Username = new Label();
            Userbox = new TextBox();
            label1 = new Label();
            Passbox = new TextBox();
            Login_Button = new Button();
            BacktoRegister = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("HP Simplified Hans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(107, 99);
            Username.Name = "Username";
            Username.Size = new Size(113, 26);
            Username.TabIndex = 0;
            Username.Text = "Username";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Userbox
            // 
            Userbox.Location = new Point(259, 100);
            Userbox.Name = "Userbox";
            Userbox.Size = new Size(210, 27);
            Userbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 186);
            label1.Name = "label1";
            label1.Size = new Size(109, 26);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // Passbox
            // 
            Passbox.Location = new Point(259, 189);
            Passbox.Name = "Passbox";
            Passbox.PasswordChar = '5';
            Passbox.Size = new Size(210, 27);
            Passbox.TabIndex = 3;
            Passbox.UseSystemPasswordChar = true;
            // 
            // Login_Button
            // 
            Login_Button.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Button.Location = new Point(375, 268);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(94, 43);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // BacktoRegister
            // 
            BacktoRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BacktoRegister.Location = new Point(98, 268);
            BacktoRegister.Name = "BacktoRegister";
            BacktoRegister.Size = new Size(173, 43);
            BacktoRegister.TabIndex = 5;
            BacktoRegister.Text = "Back to Register";
            BacktoRegister.UseVisualStyleBackColor = true;
            BacktoRegister.Click += BacktoRegister_Click;
            // 
            // backgroundWorker1
            // 
            
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 383);
            Controls.Add(BacktoRegister);
            Controls.Add(Login_Button);
            Controls.Add(Passbox);
            Controls.Add(label1);
            Controls.Add(Userbox);
            Controls.Add(Username);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox Userbox;
        private Label label1;
        private TextBox Passbox;
        private Button Login_Button;
        private Button BacktoRegister;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}