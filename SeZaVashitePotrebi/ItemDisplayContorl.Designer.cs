namespace SeZaVashitePotrebi
{
    partial class ItemDisplayContorl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(247, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.ItemDisplayContorl_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.lblName.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(263, 55);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.ItemDisplayContorl_Click);
            this.lblCategory.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.lblCategory.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(263, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 23);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.ItemDisplayContorl_Click);
            this.lblType.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.lblType.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(263, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 28);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.ItemDisplayContorl_Click);
            this.lblPrice.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.lblPrice.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ItemDisplayContorl_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(247, 180);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(94, 29);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            this.btnAddToCart.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.btnAddToCart.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(247, 180);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "Remove";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            this.btnRemoveFromCart.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.btnRemoveFromCart.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(247, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ItemDisplayContorl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ItemDisplayContorl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(394, 270);
            this.Load += new System.EventHandler(this.ItemDisplayContorl_Load);
            this.Click += new System.EventHandler(this.ItemDisplayContorl_Click);
            this.MouseEnter += new System.EventHandler(this.ItemDisplayContorl_MouseHover);
            this.MouseLeave += new System.EventHandler(this.ItemDisplayContorl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblCategory;
        private Label lblType;
        private Label lblPrice;
        private PictureBox pictureBox1;
        public Button btnAddToCart;
        private Button btnRemoveFromCart;
        public Button btnDelete;
    }
}
