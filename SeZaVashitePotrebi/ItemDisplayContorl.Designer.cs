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
            lblName = new Label();
            lblCategory = new Label();
            lblType = new Label();
            lblPrice = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(87, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(67, 35);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(96, 55);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(87, 75);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 99);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ItemDisplayContorl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblPrice);
            Controls.Add(lblType);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Name = "ItemDisplayContorl";
            Size = new Size(251, 244);
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
    }
}
