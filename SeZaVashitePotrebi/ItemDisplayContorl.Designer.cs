﻿namespace SeZaVashitePotrebi
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
            lblName = new Label();
            lblCategory = new Label();
            lblType = new Label();
            lblPrice = new Label();
            pictureBox1 = new PictureBox();
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(247, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += ItemDisplayContorl_Click;
            lblName.MouseEnter += ItemDisplayContorl_MouseHover;
            lblName.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(263, 55);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 23);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            lblCategory.Click += ItemDisplayContorl_Click;
            lblCategory.MouseEnter += ItemDisplayContorl_MouseHover;
            lblCategory.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.Location = new Point(263, 92);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 23);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            lblType.Click += ItemDisplayContorl_Click;
            lblType.MouseEnter += ItemDisplayContorl_MouseHover;
            lblType.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(263, 133);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 28);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            lblPrice.Click += ItemDisplayContorl_Click;
            lblPrice.MouseEnter += ItemDisplayContorl_MouseHover;
            lblPrice.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ItemDisplayContorl_Click;
            pictureBox1.MouseEnter += ItemDisplayContorl_MouseHover;
            pictureBox1.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(247, 180);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 29);
            btnAddToCart.TabIndex = 5;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            btnAddToCart.MouseEnter += ItemDisplayContorl_MouseHover;
            btnAddToCart.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(248, 180);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(94, 29);
            btnRemoveFromCart.TabIndex = 6;
            btnRemoveFromCart.Text = "Remove";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            btnRemoveFromCart.MouseEnter += ItemDisplayContorl_MouseHover;
            btnRemoveFromCart.MouseLeave += ItemDisplayContorl_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(247, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ItemDisplayContorl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnDelete);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrice);
            Controls.Add(lblType);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "ItemDisplayContorl";
            RightToLeft = RightToLeft.No;
            Size = new Size(394, 270);
            Load += ItemDisplayContorl_Load;
            Click += ItemDisplayContorl_Click;
            MouseEnter += ItemDisplayContorl_MouseHover;
            MouseLeave += ItemDisplayContorl_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
