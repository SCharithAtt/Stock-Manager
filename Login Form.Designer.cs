namespace Stock_Manager
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(211, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.SystemColors.Window;
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameInput.Location = new System.Drawing.Point(134, 124);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(205, 26);
            this.usernameInput.TabIndex = 1;
            this.usernameInput.Text = "Username";
            this.usernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_Enter);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordInput.Location = new System.Drawing.Point(134, 203);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(205, 26);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.Text = "Password";
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            this.passwordInput.Enter += new System.EventHandler(this.passwordInput_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(202, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 32);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(473, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 16);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblClose;
    }
}

