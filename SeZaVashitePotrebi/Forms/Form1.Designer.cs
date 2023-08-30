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
            this.components = new System.ComponentModel.Container();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCategory = new System.Windows.Forms.Label();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uname = new System.Windows.Forms.Label();
            this.btnMyAcc = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(11, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(473, 27);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Azure;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(491, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Azure;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(608, 12);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(86, 36);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Azure;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(701, 12);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 36);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Azure;
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Location = new System.Drawing.Point(997, 67);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(86, 31);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post Item";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Electronics",
            "Books",
            "Clothing"});
            this.comboBox1.Location = new System.Drawing.Point(87, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(SeZaVashitePotrebi.Item);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataSource = typeof(SeZaVashitePotrebi.Item);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(778, 228);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uname.Location = new System.Drawing.Point(241, 419);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(70, 25);
            this.uname.TabIndex = 8;
            this.uname.Text = "label1";
            // 
            // btnMyAcc
            // 
            this.btnMyAcc.BackColor = System.Drawing.Color.Azure;
            this.btnMyAcc.FlatAppearance.BorderSize = 0;
            this.btnMyAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAcc.Location = new System.Drawing.Point(36, 419);
            this.btnMyAcc.Name = "btnMyAcc";
            this.btnMyAcc.Size = new System.Drawing.Size(94, 29);
            this.btnMyAcc.TabIndex = 9;
            this.btnMyAcc.Text = "button1";
            this.btnMyAcc.UseVisualStyleBackColor = false;
            this.btnMyAcc.Click += new System.EventHandler(this.btnMyAcc_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Azure;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Location = new System.Drawing.Point(813, 19);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(94, 29);
            this.btnCart.TabIndex = 10;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1116, 508);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnMyAcc);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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