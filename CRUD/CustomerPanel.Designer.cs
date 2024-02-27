namespace CRUD
{
    partial class CustomerPanel
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
            username = new Label();
            useremail = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(141, 40);
            username.Name = "username";
            username.Size = new Size(38, 15);
            username.TabIndex = 0;
            username.Text = "label1";
            // 
            // useremail
            // 
            useremail.AutoSize = true;
            useremail.Location = new Point(147, 100);
            useremail.Name = "useremail";
            useremail.Size = new Size(38, 15);
            useremail.TabIndex = 1;
            useremail.Text = "label2";
            // 
            // CustomerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(870, 355);
            Controls.Add(useremail);
            Controls.Add(username);
            Name = "CustomerPanel";
            Text = "CustomerPanel";
            Load += CustomerPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label useremail;
    }
}