namespace SeZaVashitePotrebi.Forms
{
    partial class ItemDetails
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
            pictureBox1 = new PictureBox();
            lbItemName = new Label();
            lblType = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbItemName
            // 
            lbItemName.AutoSize = true;
            lbItemName.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbItemName.Location = new Point(235, 12);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(110, 24);
            lbItemName.TabIndex = 1;
            lbItemName.Text = "lblname";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Felix Titling", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(235, 53);
            lblType.Name = "lblType";
            lblType.Size = new Size(96, 24);
            lblType.TabIndex = 2;
            lblType.Text = "lblType";
            // 
            // ItemDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 331);
            Controls.Add(lblType);
            Controls.Add(lbItemName);
            Controls.Add(pictureBox1);
            Name = "ItemDetails";
            Text = "ItemDetails";
            Load += ItemDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbItemName;
        private Label lblType;
    }
}