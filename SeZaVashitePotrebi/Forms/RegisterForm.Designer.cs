namespace SeZaVashitePotrebi
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
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbCity = new TextBox();
            tbCountry = new TextBox();
            tbPhoneNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            rbSeller = new RadioButton();
            rbBuyer = new RadioButton();
            SuspendLayout();
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(12, 39);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(125, 27);
            tbUserName.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(143, 39);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 102);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(256, 27);
            tbEmail.TabIndex = 2;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(12, 169);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(125, 27);
            tbCity.TabIndex = 3;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(143, 169);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 4;
            // 
            // tbPhoneNum
            // 
            tbPhoneNum.Location = new Point(12, 226);
            tbPhoneNum.Name = "tbPhoneNum";
            tbPhoneNum.Size = new Size(256, 27);
            tbPhoneNum.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 16);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 8;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 9;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 146);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 10;
            label5.Text = "Country:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 203);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 11;
            label6.Text = "Phone Number:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(96, 326);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // rbSeller
            // 
            rbSeller.AutoSize = true;
            rbSeller.Location = new Point(36, 287);
            rbSeller.Name = "rbSeller";
            rbSeller.Size = new Size(67, 24);
            rbSeller.TabIndex = 13;
            rbSeller.TabStop = true;
            rbSeller.Text = "Seller";
            rbSeller.UseVisualStyleBackColor = true;
            // 
            // rbBuyer
            // 
            rbBuyer.AutoSize = true;
            rbBuyer.Location = new Point(179, 287);
            rbBuyer.Name = "rbBuyer";
            rbBuyer.Size = new Size(67, 24);
            rbBuyer.TabIndex = 14;
            rbBuyer.TabStop = true;
            rbBuyer.Text = "Buyer";
            rbBuyer.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 387);
            Controls.Add(rbBuyer);
            Controls.Add(rbSeller);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPhoneNum);
            Controls.Add(tbCountry);
            Controls.Add(tbCity);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUserName;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbCity;
        private TextBox tbCountry;
        private TextBox tbPhoneNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private RadioButton rbSeller;
        private RadioButton rbBuyer;
    }
}