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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRentalPeriod = new System.Windows.Forms.Label();
            this.numericUpDownRentalPeriod = new System.Windows.Forms.NumericUpDown();
            this.daysLbl = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(22, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(17, 144);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(156, 32);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(179, 144);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(209, 27);
            this.txtDesc.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(87, 204);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 32);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(179, 204);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(209, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // comboType
            // 
            this.comboType.AutoCompleteCustomSource.AddRange(new string[] {
            "Buy",
            "Rent"});
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(179, 331);
            this.comboType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(209, 28);
            this.comboType.TabIndex = 6;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(87, 331);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 32);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type: ";
            // 
            // lblRentalPeriod
            // 
            this.lblRentalPeriod.AutoSize = true;
            this.lblRentalPeriod.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentalPeriod.Location = new System.Drawing.Point(0, 376);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Size = new System.Drawing.Size(179, 32);
            this.lblRentalPeriod.TabIndex = 8;
            this.lblRentalPeriod.Text = "Rental Period:";
            // 
            // numericUpDownRentalPeriod
            // 
            this.numericUpDownRentalPeriod.Location = new System.Drawing.Point(179, 381);
            this.numericUpDownRentalPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRentalPeriod.Name = "numericUpDownRentalPeriod";
            this.numericUpDownRentalPeriod.Size = new System.Drawing.Size(137, 27);
            this.numericUpDownRentalPeriod.TabIndex = 9;
            // 
            // daysLbl
            // 
            this.daysLbl.AutoSize = true;
            this.daysLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daysLbl.Location = new System.Drawing.Point(323, 381);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(63, 32);
            this.daysLbl.TabIndex = 10;
            this.daysLbl.Text = "days";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpload.Location = new System.Drawing.Point(416, 95);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(202, 32);
            this.lblUpload.TabIndex = 11;
            this.lblUpload.Text = "Upload a photo:";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(453, 131);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(102, 53);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(624, 84);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(269, 248);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(265, 476);
            this.btnPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(123, 85);
            this.btnPost.TabIndex = 14;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(545, 476);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 85);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(179, 269);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(209, 28);
            this.comboCategory.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(46, 265);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 32);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // PostItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.daysLbl);
            this.Controls.Add(this.numericUpDownRentalPeriod);
            this.Controls.Add(this.lblRentalPeriod);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PostItemForm";
            this.Text = "PostItemForm";
            this.Load += new System.EventHandler(this.PostItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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