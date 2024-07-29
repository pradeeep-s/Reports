namespace Reports.Forms
{
    partial class RegisterForm
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
            label1 = new Label();
            Userbox = new TextBox();
            Passbox = new TextBox();
            label2 = new Label();
            DBUserbox = new TextBox();
            label3 = new Label();
            DBPassbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Datebox = new DateTimePicker();
            Register_Button = new Button();
            Back_Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 104);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Userbox
            // 
            Userbox.Location = new Point(371, 105);
            Userbox.Name = "Userbox";
            Userbox.Size = new Size(187, 27);
            Userbox.TabIndex = 1;
            // 
            // Passbox
            // 
            Passbox.Location = new Point(371, 161);
            Passbox.Name = "Passbox";
            Passbox.PasswordChar = '5';
            Passbox.Size = new Size(187, 27);
            Passbox.TabIndex = 3;
            Passbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 160);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // DBUserbox
            // 
            DBUserbox.Location = new Point(371, 211);
            DBUserbox.Name = "DBUserbox";
            DBUserbox.Size = new Size(187, 27);
            DBUserbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 210);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 4;
            label3.Text = "DB Username";
            // 
            // DBPassbox
            // 
            DBPassbox.Location = new Point(371, 266);
            DBPassbox.Name = "DBPassbox";
            DBPassbox.Size = new Size(187, 27);
            DBPassbox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(226, 266);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 6;
            label4.Text = "DB Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(229, 321);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 8;
            label5.Text = "License Date";
            // 
            // Datebox
            // 
            Datebox.CustomFormat = "dd-MM-yyyy";
            Datebox.Location = new Point(371, 323);
            Datebox.Name = "Datebox";
            Datebox.Size = new Size(187, 27);
            Datebox.TabIndex = 9;
            Datebox.Value = new DateTime(2024, 7, 24, 0, 0, 0, 0);
            // 
            // Register_Button
            // 
            Register_Button.Location = new Point(464, 401);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(94, 29);
            Register_Button.TabIndex = 10;
            Register_Button.Text = "Register";
            Register_Button.UseVisualStyleBackColor = true;
            Register_Button.Click += Register_Button_Click;
            // 
            // Back_Login
            // 
            Back_Login.Location = new Point(229, 401);
            Back_Login.Name = "Back_Login";
            Back_Login.Size = new Size(120, 29);
            Back_Login.TabIndex = 11;
            Back_Login.Text = "Back to Login";
            Back_Login.UseVisualStyleBackColor = true;
            Back_Login.Click += Back_Login_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 487);
            Controls.Add(Back_Login);
            Controls.Add(Register_Button);
            Controls.Add(Datebox);
            Controls.Add(label5);
            Controls.Add(DBPassbox);
            Controls.Add(label4);
            Controls.Add(DBUserbox);
            Controls.Add(label3);
            Controls.Add(Passbox);
            Controls.Add(label2);
            Controls.Add(Userbox);
            Controls.Add(label1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Userbox;
        private TextBox Passbox;
        private Label label2;
        private TextBox DBUserbox;
        private Label label3;
        private TextBox DBPassbox;
        private Label label4;
        private Label label5;
        private DateTimePicker Datebox;
        private Button Register_Button;
        private Button Back_Login;
    }
}