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
            tbSearch = new TextBox();
            btnSearch = new Button();
            btnLogIn = new Button();
            btnRegister = new Button();
            btnPost = new Button();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(11, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(473, 27);
            tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(491, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 36);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(608, 12);
            btnLogIn.Margin = new Padding(3, 4, 3, 4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(86, 36);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "LOG IN";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(701, 12);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 36);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(997, 67);
            btnPost.Margin = new Padding(3, 4, 3, 4);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(86, 31);
            btnPost.TabIndex = 4;
            btnPost.Text = "Post Item";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 50);
            ClientSize = new Size(1095, 487);
            Controls.Add(btnPost);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Button btnSearch;
        private Button btnLogIn;
        private Button btnRegister;
        private Button btnPost;
    }
}