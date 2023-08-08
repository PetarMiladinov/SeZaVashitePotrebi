namespace SeZaVashitePotrebi
{
    partial class PostItemForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblDesc = new Label();
            txtDesc = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            comboType = new ComboBox();
            lblType = new Label();
            lblRentalPeriod = new Label();
            numericUpDownRentalPeriod = new NumericUpDown();
            daysLbl = new Label();
            lblUpload = new Label();
            btnUpload = new Button();
            pictureBox = new PictureBox();
            btnPost = new Button();
            btnCancel = new Button();
            comboCategory = new ComboBox();
            lblCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRentalPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(22, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(151, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Item Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 84);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesc.Location = new Point(17, 144);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(156, 32);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(179, 144);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(209, 27);
            txtDesc.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(87, 204);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(80, 32);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(179, 204);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 5;
            // 
            // comboType
            // 
            comboType.AutoCompleteCustomSource.AddRange(new string[] { "Buy", "Rent" });
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(179, 331);
            comboType.Margin = new Padding(3, 4, 3, 4);
            comboType.Name = "comboType";
            comboType.Size = new Size(209, 28);
            comboType.TabIndex = 6;
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(87, 331);
            lblType.Name = "lblType";
            lblType.Size = new Size(86, 32);
            lblType.TabIndex = 7;
            lblType.Text = "Type: ";
            // 
            // lblRentalPeriod
            // 
            lblRentalPeriod.AutoSize = true;
            lblRentalPeriod.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRentalPeriod.Location = new Point(0, 376);
            lblRentalPeriod.Name = "lblRentalPeriod";
            lblRentalPeriod.Size = new Size(179, 32);
            lblRentalPeriod.TabIndex = 8;
            lblRentalPeriod.Text = "Rental Period:";
            // 
            // numericUpDownRentalPeriod
            // 
            numericUpDownRentalPeriod.Location = new Point(179, 381);
            numericUpDownRentalPeriod.Margin = new Padding(3, 4, 3, 4);
            numericUpDownRentalPeriod.Name = "numericUpDownRentalPeriod";
            numericUpDownRentalPeriod.Size = new Size(137, 27);
            numericUpDownRentalPeriod.TabIndex = 9;
            // 
            // daysLbl
            // 
            daysLbl.AutoSize = true;
            daysLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            daysLbl.Location = new Point(323, 381);
            daysLbl.Name = "daysLbl";
            daysLbl.Size = new Size(63, 32);
            daysLbl.TabIndex = 10;
            daysLbl.Text = "days";
            // 
            // lblUpload
            // 
            lblUpload.AutoSize = true;
            lblUpload.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpload.Location = new Point(416, 95);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(202, 32);
            lblUpload.TabIndex = 11;
            lblUpload.Text = "Upload a photo:";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(453, 131);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(102, 53);
            btnUpload.TabIndex = 12;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(624, 84);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(269, 248);
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.LimeGreen;
            btnPost.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnPost.Location = new Point(265, 476);
            btnPost.Margin = new Padding(3, 4, 3, 4);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(123, 85);
            btnPost.TabIndex = 14;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnCancel.Location = new Point(545, 476);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 85);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(179, 269);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(209, 28);
            comboCategory.TabIndex = 16;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.Location = new Point(46, 265);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(127, 32);
            lblCategory.TabIndex = 17;
            lblCategory.Text = "Category:";
            // 
            // PostItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblCategory);
            Controls.Add(comboCategory);
            Controls.Add(btnCancel);
            Controls.Add(btnPost);
            Controls.Add(pictureBox);
            Controls.Add(btnUpload);
            Controls.Add(lblUpload);
            Controls.Add(daysLbl);
            Controls.Add(numericUpDownRentalPeriod);
            Controls.Add(lblRentalPeriod);
            Controls.Add(lblType);
            Controls.Add(comboType);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PostItemForm";
            Text = "PostItemForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRentalPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblDesc;
        private TextBox txtDesc;
        private Label lblPrice;
        private TextBox txtPrice;
        private ComboBox comboType;
        private Label lblType;
        private Label lblRentalPeriod;
        private NumericUpDown numericUpDownRentalPeriod;
        private Label daysLbl;
        private Label lblUpload;
        private Button btnUpload;
        private PictureBox pictureBox;
        private Button btnPost;
        private Button btnCancel;
        private ComboBox comboCategory;
        private Label lblCategory;
    }
}