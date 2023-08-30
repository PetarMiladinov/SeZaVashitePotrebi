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
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRentalPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(28, 24);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(224, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(28, 79);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(156, 32);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(109, 204);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 32);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(224, 204);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 27);
            this.txtPrice.TabIndex = 5;
            // 
            // comboType
            // 
            this.comboType.AutoCompleteCustomSource.AddRange(new string[] {
            "Buy",
            "Rent"});
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(224, 331);
            this.comboType.Margin = new System.Windows.Forms.Padding(4);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(260, 28);
            this.comboType.TabIndex = 6;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(109, 331);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblRentalPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalPeriod.Name = "lblRentalPeriod";
            this.lblRentalPeriod.Size = new System.Drawing.Size(179, 32);
            this.lblRentalPeriod.TabIndex = 8;
            this.lblRentalPeriod.Text = "Rental Period:";
            // 
            // numericUpDownRentalPeriod
            // 
            this.numericUpDownRentalPeriod.Location = new System.Drawing.Point(224, 381);
            this.numericUpDownRentalPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRentalPeriod.Name = "numericUpDownRentalPeriod";
            this.numericUpDownRentalPeriod.Size = new System.Drawing.Size(171, 27);
            this.numericUpDownRentalPeriod.TabIndex = 9;
            // 
            // daysLbl
            // 
            this.daysLbl.AutoSize = true;
            this.daysLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daysLbl.Location = new System.Drawing.Point(404, 381);
            this.daysLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daysLbl.Name = "daysLbl";
            this.daysLbl.Size = new System.Drawing.Size(63, 32);
            this.daysLbl.TabIndex = 10;
            this.daysLbl.Text = "days";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpload.Location = new System.Drawing.Point(566, 24);
            this.lblUpload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(202, 32);
            this.lblUpload.TabIndex = 11;
            this.lblUpload.Text = "Upload a photo:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Azure;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(566, 355);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(128, 53);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(566, 79);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(336, 248);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.Azure;
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPost.Location = new System.Drawing.Point(241, 476);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(154, 85);
            this.btnPost.TabIndex = 14;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(566, 476);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 85);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(224, 269);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(260, 28);
            this.comboCategory.TabIndex = 16;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(58, 265);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 32);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(224, 79);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(260, 106);
            this.rtbDesc.TabIndex = 18;
            this.rtbDesc.Text = "";
            // 
            // PostItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(936, 600);
            this.Controls.Add(this.rtbDesc);
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
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private RichTextBox rtbDesc;
    }
}