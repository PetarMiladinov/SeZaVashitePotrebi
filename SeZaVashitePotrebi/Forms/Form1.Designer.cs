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
            components = new System.ComponentModel.Container();
            tbSearch = new TextBox();
            btnSearch = new Button();
            btnLogIn = new Button();
            btnRegister = new Button();
            btnPost = new Button();
            comboBox1 = new ComboBox();
            itemBindingSource = new BindingSource(components);
            lblCategory = new Label();
            itemBindingSource1 = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            uname = new Label();
            btnMyAcc = new Button();
            btnCart = new Button();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).BeginInit();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Electronics", "Books", "Clothing" });
            comboBox1.Location = new Point(87, 49);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 5;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(14, 53);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            // 
            // itemBindingSource1
            // 
            itemBindingSource1.DataSource = typeof(Item);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(2, 110);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 228);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // uname
            // 
            uname.AutoSize = true;
            uname.Location = new Point(241, 419);
            uname.Name = "uname";
            uname.Size = new Size(50, 20);
            uname.TabIndex = 8;
            uname.Text = "label1";
            // 
            // btnMyAcc
            // 
            btnMyAcc.Location = new Point(36, 419);
            btnMyAcc.Name = "btnMyAcc";
            btnMyAcc.Size = new Size(94, 29);
            btnMyAcc.TabIndex = 9;
            btnMyAcc.Text = "button1";
            btnMyAcc.UseVisualStyleBackColor = true;
            btnMyAcc.Click += btnMyAcc_Click;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(813, 19);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(94, 29);
            btnCart.TabIndex = 10;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 50);
            ClientSize = new Size(1095, 487);
            Controls.Add(btnCart);
            Controls.Add(btnMyAcc);
            Controls.Add(uname);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblCategory);
            Controls.Add(comboBox1);
            Controls.Add(btnPost);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Button btnSearch;
        private Button btnLogIn;
        private Button btnRegister;
        private Button btnPost;
        private ComboBox comboBox1;
        private Label lblCategory;
        private BindingSource itemBindingSource;
        private BindingSource itemBindingSource1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label uname;
        private Button btnMyAcc;
        private Button btnCart;
    }
}