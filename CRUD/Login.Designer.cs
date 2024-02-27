namespace CRUD
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label4 = new Label();
            label5 = new Label();
            loginBtn = new Button();
            userLoginPassword = new TextBox();
            label3 = new Label();
            userLoginEmail = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(157, 312);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 20;
            label4.Text = "Registration";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 312);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 19;
            label5.Text = "dont have an account ?";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Yellow;
            loginBtn.ForeColor = SystemColors.ActiveCaptionText;
            loginBtn.Location = new Point(93, 338);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(80, 29);
            loginBtn.TabIndex = 18;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // userLoginPassword
            // 
            userLoginPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userLoginPassword.Location = new Point(43, 278);
            userLoginPassword.Name = "userLoginPassword";
            userLoginPassword.PasswordChar = '*';
            userLoginPassword.Size = new Size(198, 27);
            userLoginPassword.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 251);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // userLoginEmail
            // 
            userLoginEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userLoginEmail.Location = new Point(43, 209);
            userLoginEmail.Name = "userLoginEmail";
            userLoginEmail.Size = new Size(198, 27);
            userLoginEmail.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 182);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 14;
            label2.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(43, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(300, 438);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(loginBtn);
            Controls.Add(userLoginPassword);
            Controls.Add(label3);
            Controls.Add(userLoginEmail);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "APTECH COMPUTER EDUCATION";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private Button loginBtn;
        private TextBox userLoginPassword;
        private Label label3;
        private TextBox userLoginEmail;
        private Label label2;
        private PictureBox pictureBox1;
    }
}