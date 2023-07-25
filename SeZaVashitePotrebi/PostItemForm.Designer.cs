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
            ((System.ComponentModel.ISupportInitialize)numericUpDownRentalPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(32, 63);
            lblName.Name = "lblName";
            lblName.Size = new Size(122, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Item Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesc.Location = new Point(29, 108);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(125, 25);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(157, 108);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(183, 23);
            txtDesc.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(87, 153);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(157, 153);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(183, 23);
            txtPrice.TabIndex = 5;
            // 
            // comboType
            // 
            comboType.AutoCompleteCustomSource.AddRange(new string[] { "Buy", "Rent" });
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(157, 198);
            comboType.Name = "comboType";
            comboType.Size = new Size(183, 23);
            comboType.TabIndex = 6;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(85, 196);
            lblType.Name = "lblType";
            lblType.Size = new Size(69, 25);
            lblType.TabIndex = 7;
            lblType.Text = "Type: ";
            // 
            // lblRentalPeriod
            // 
            lblRentalPeriod.AutoSize = true;
            lblRentalPeriod.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRentalPeriod.Location = new Point(9, 237);
            lblRentalPeriod.Name = "lblRentalPeriod";
            lblRentalPeriod.Size = new Size(145, 25);
            lblRentalPeriod.TabIndex = 8;
            lblRentalPeriod.Text = "Rental Period:";
            // 
            // numericUpDownRentalPeriod
            // 
            numericUpDownRentalPeriod.Location = new Point(160, 239);
            numericUpDownRentalPeriod.Name = "numericUpDownRentalPeriod";
            numericUpDownRentalPeriod.Size = new Size(120, 23);
            numericUpDownRentalPeriod.TabIndex = 9;
            // 
            // daysLbl
            // 
            daysLbl.AutoSize = true;
            daysLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            daysLbl.Location = new Point(289, 237);
            daysLbl.Name = "daysLbl";
            daysLbl.Size = new Size(51, 25);
            daysLbl.TabIndex = 10;
            daysLbl.Text = "days";
            // 
            // lblUpload
            // 
            lblUpload.AutoSize = true;
            lblUpload.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUpload.Location = new Point(388, 70);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(162, 25);
            lblUpload.TabIndex = 11;
            lblUpload.Text = "Upload a photo:";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(420, 98);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(89, 40);
            btnUpload.TabIndex = 12;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(546, 63);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(235, 186);
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            // 
            // btnPost
            // 
            btnPost.BackColor = Color.LimeGreen;
            btnPost.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnPost.Location = new Point(232, 357);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(108, 64);
            btnPost.TabIndex = 14;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnCancel.Location = new Point(477, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 64);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // PostItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}