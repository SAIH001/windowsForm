namespace CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            username = new TextBox();
            useremail = new TextBox();
            label2 = new Label();
            userpassword = new TextBox();
            label3 = new Label();
            registrationBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            connectbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(65, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 196);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(74, 223);
            username.Name = "username";
            username.Size = new Size(198, 27);
            username.TabIndex = 2;
            // 
            // useremail
            // 
            useremail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            useremail.Location = new Point(74, 290);
            useremail.Name = "useremail";
            useremail.Size = new Size(198, 27);
            useremail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 263);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // userpassword
            // 
            userpassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userpassword.Location = new Point(74, 359);
            userpassword.Name = "userpassword";
            userpassword.PasswordChar = '*';
            userpassword.Size = new Size(198, 27);
            userpassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 332);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // registrationBtn
            // 
            registrationBtn.BackColor = Color.Yellow;
            registrationBtn.ForeColor = SystemColors.ActiveCaptionText;
            registrationBtn.Location = new Point(124, 419);
            registrationBtn.Name = "registrationBtn";
            registrationBtn.Size = new Size(80, 29);
            registrationBtn.TabIndex = 7;
            registrationBtn.Text = "Registration";
            registrationBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 393);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 9;
            label5.Text = "have an account ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(188, 393);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "Login";
            label4.Click += label4_Click;
            // 
            // connectbtn
            // 
            connectbtn.BackColor = Color.Yellow;
            connectbtn.ForeColor = SystemColors.ActiveCaptionText;
            connectbtn.Location = new Point(124, 454);
            connectbtn.Name = "connectbtn";
            connectbtn.Size = new Size(80, 29);
            connectbtn.TabIndex = 11;
            connectbtn.Text = "Connect";
            connectbtn.UseVisualStyleBackColor = false;
            connectbtn.Click += connectbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(344, 494);
            Controls.Add(connectbtn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(registrationBtn);
            Controls.Add(userpassword);
            Controls.Add(label3);
            Controls.Add(useremail);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "APTECH COMPUTER EDUCATION";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox username;
        private TextBox useremail;
        private Label label2;
        private TextBox userpassword;
        private Label label3;
        private Button registrationBtn;
        private Label label5;
        private Label label4;
        private Button connectbtn;
    }
}