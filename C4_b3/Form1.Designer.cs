namespace c4
{
    partial class Form1
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
			this.lblMaHang = new System.Windows.Forms.Label();
			this.lblDonGia = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaHang = new System.Windows.Forms.TextBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.chkGiamGia = new System.Windows.Forms.CheckBox();
			this.rad5 = new System.Windows.Forms.RadioButton();
			this.rad10 = new System.Windows.Forms.RadioButton();
			this.btnThucHien = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMaHang
			// 
			this.lblMaHang.AutoSize = true;
			this.lblMaHang.Location = new System.Drawing.Point(40, 67);
			this.lblMaHang.Name = "lblMaHang";
			this.lblMaHang.Size = new System.Drawing.Size(99, 25);
			this.lblMaHang.TabIndex = 0;
			this.lblMaHang.Text = "Mã Hàng";
			// 
			// lblDonGia
			// 
			this.lblDonGia.AutoSize = true;
			this.lblDonGia.Location = new System.Drawing.Point(40, 129);
			this.lblDonGia.Name = "lblDonGia";
			this.lblDonGia.Size = new System.Drawing.Size(90, 25);
			this.lblDonGia.TabIndex = 1;
			this.lblDonGia.Text = "Đơn Giá";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 174);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Số lượng";
			// 
			// txtMaHang
			// 
			this.txtMaHang.Location = new System.Drawing.Point(173, 60);
			this.txtMaHang.Name = "txtMaHang";
			this.txtMaHang.Size = new System.Drawing.Size(204, 31);
			this.txtMaHang.TabIndex = 3;
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(173, 122);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(204, 31);
			this.txtDonGia.TabIndex = 4;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(173, 167);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(204, 31);
			this.txtSoLuong.TabIndex = 5;
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Location = new System.Drawing.Point(448, 104);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(108, 25);
			this.lblTongTien.TabIndex = 6;
			this.lblTongTien.Text = "Tổng tiền:";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(563, 97);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(189, 31);
			this.txtTongTien.TabIndex = 7;
			// 
			// chkGiamGia
			// 
			this.chkGiamGia.AutoSize = true;
			this.chkGiamGia.Location = new System.Drawing.Point(45, 260);
			this.chkGiamGia.Name = "chkGiamGia";
			this.chkGiamGia.Size = new System.Drawing.Size(129, 29);
			this.chkGiamGia.TabIndex = 8;
			this.chkGiamGia.Text = "Giảm giá";
			this.chkGiamGia.UseVisualStyleBackColor = true;
			this.chkGiamGia.CheckedChanged += new System.EventHandler(this.chkGiamGia_CheckedChanged);
			// 
			// rad5
			// 
			this.rad5.AutoSize = true;
			this.rad5.Location = new System.Drawing.Point(206, 260);
			this.rad5.Name = "rad5";
			this.rad5.Size = new System.Drawing.Size(74, 29);
			this.rad5.TabIndex = 9;
			this.rad5.TabStop = true;
			this.rad5.Text = "5%";
			this.rad5.UseVisualStyleBackColor = true;
			// 
			// rad10
			// 
			this.rad10.AutoSize = true;
			this.rad10.Location = new System.Drawing.Point(307, 260);
			this.rad10.Name = "rad10";
			this.rad10.Size = new System.Drawing.Size(86, 29);
			this.rad10.TabIndex = 10;
			this.rad10.TabStop = true;
			this.rad10.Text = "10%";
			this.rad10.UseVisualStyleBackColor = true;
			// 
			// btnThucHien
			// 
			this.btnThucHien.Location = new System.Drawing.Point(291, 372);
			this.btnThucHien.Name = "btnThucHien";
			this.btnThucHien.Size = new System.Drawing.Size(142, 36);
			this.btnThucHien.TabIndex = 11;
			this.btnThucHien.Text = "Thực hiện";
			this.btnThucHien.UseVisualStyleBackColor = true;
			this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(473, 372);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(142, 36);
			this.btnThoat.TabIndex = 12;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnThucHien);
			this.Controls.Add(this.rad10);
			this.Controls.Add(this.rad5);
			this.Controls.Add(this.chkGiamGia);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.txtMaHang);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblDonGia);
			this.Controls.Add(this.lblMaHang);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
    }
}

