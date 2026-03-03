namespace c4
{
    partial class Main
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
			this.SoLuong = new System.Windows.Forms.Label();
			this.DonGia = new System.Windows.Forms.Label();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SoLuong
			// 
			this.SoLuong.AutoSize = true;
			this.SoLuong.Location = new System.Drawing.Point(265, 125);
			this.SoLuong.Name = "SoLuong";
			this.SoLuong.Size = new System.Drawing.Size(104, 25);
			this.SoLuong.TabIndex = 0;
			this.SoLuong.Text = "Số Lượng";
			// 
			// DonGia
			// 
			this.DonGia.AutoSize = true;
			this.DonGia.Location = new System.Drawing.Point(265, 180);
			this.DonGia.Name = "DonGia";
			this.DonGia.Size = new System.Drawing.Size(90, 25);
			this.DonGia.TabIndex = 1;
			this.DonGia.Text = "Đơn Giá";
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(270, 224);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(135, 47);
			this.btnTinhTien.TabIndex = 2;
			this.btnTinhTien.Text = "Tính Tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Location = new System.Drawing.Point(411, 235);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(109, 25);
			this.lblTongTien.TabIndex = 3;
			this.lblTongTien.Text = "Tổng Tiền";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(375, 119);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(100, 31);
			this.txtSoLuong.TabIndex = 4;
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(375, 174);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(100, 31);
			this.txtDonGia.TabIndex = 5;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.DonGia);
			this.Controls.Add(this.SoLuong);
			this.Name = "Main";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.Label DonGia;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}