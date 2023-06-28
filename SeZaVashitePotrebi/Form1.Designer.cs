namespace SeZaVashitePotrebi
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
            txtUsernameInput = new TextBox();
            txtPasswordInput = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            txtEmailInput = new TextBox();
            SuspendLayout();
            // 
            // txtUsernameInput
            // 
            txtUsernameInput.Location = new Point(331, 114);
            txtUsernameInput.Name = "txtUsernameInput";
            txtUsernameInput.Size = new Size(125, 27);
            txtUsernameInput.TabIndex = 0;
            txtUsernameInput.Text = "Username";
            // 
            // txtPasswordInput
            // 
            txtPasswordInput.Location = new Point(331, 147);
            txtPasswordInput.Name = "txtPasswordInput";
            txtPasswordInput.PasswordChar = '/';
            txtPasswordInput.Size = new Size(125, 27);
            txtPasswordInput.TabIndex = 1;
            txtPasswordInput.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(348, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(348, 217);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmailInput
            // 
            txtEmailInput.Location = new Point(331, 184);
            txtEmailInput.Name = "txtEmailInput";
            txtEmailInput.Size = new Size(125, 27);
            txtEmailInput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmailInput);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPasswordInput);
            Controls.Add(txtUsernameInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsernameInput;
        private TextBox txtPasswordInput;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtEmailInput;
    }
}