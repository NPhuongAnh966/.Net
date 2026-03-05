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
			this.lblN = new System.Windows.Forms.Label();
			this.txtN = new System.Windows.Forms.TextBox();
			this.lblDaySo = new System.Windows.Forms.Label();
			this.lblTong = new System.Windows.Forms.Label();
			this.lblSapXep = new System.Windows.Forms.Label();
			this.btnNhap = new System.Windows.Forms.Button();
			this.btnTinhTong = new System.Windows.Forms.Button();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.btnLamLai = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblN
			// 
			this.lblN.AutoSize = true;
			this.lblN.Location = new System.Drawing.Point(176, 104);
			this.lblN.Name = "lblN";
			this.lblN.Size = new System.Drawing.Size(99, 25);
			this.lblN.TabIndex = 0;
			this.lblN.Text = "Nhập n =";
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(296, 97);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(183, 31);
			this.txtN.TabIndex = 1;
			// 
			// lblDaySo
			// 
			this.lblDaySo.AutoSize = true;
			this.lblDaySo.Location = new System.Drawing.Point(181, 157);
			this.lblDaySo.Name = "lblDaySo";
			this.lblDaySo.Size = new System.Drawing.Size(79, 25);
			this.lblDaySo.TabIndex = 2;
			this.lblDaySo.Text = "Dãy số";
			// 
			// lblTong
			// 
			this.lblTong.AutoSize = true;
			this.lblTong.Location = new System.Drawing.Point(181, 201);
			this.lblTong.Name = "lblTong";
			this.lblTong.Size = new System.Drawing.Size(137, 25);
			this.lblTong.TabIndex = 3;
			this.lblTong.Text = "Tổng Dãy Số";
			// 
			// lblSapXep
			// 
			this.lblSapXep.AutoSize = true;
			this.lblSapXep.Location = new System.Drawing.Point(181, 247);
			this.lblSapXep.Name = "lblSapXep";
			this.lblSapXep.Size = new System.Drawing.Size(97, 25);
			this.lblSapXep.TabIndex = 4;
			this.lblSapXep.Text = "Sắp xếp ";
			// 
			// btnNhap
			// 
			this.btnNhap.Location = new System.Drawing.Point(31, 305);
			this.btnNhap.Name = "btnNhap";
			this.btnNhap.Size = new System.Drawing.Size(126, 42);
			this.btnNhap.TabIndex = 5;
			this.btnNhap.Text = "Nhập";
			this.btnNhap.UseVisualStyleBackColor = true;
			this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
			// 
			// btnTinhTong
			// 
			this.btnTinhTong.Location = new System.Drawing.Point(181, 305);
			this.btnTinhTong.Name = "btnTinhTong";
			this.btnTinhTong.Size = new System.Drawing.Size(126, 42);
			this.btnTinhTong.TabIndex = 6;
			this.btnTinhTong.Text = "Tính tổng";
			this.btnTinhTong.UseVisualStyleBackColor = true;
			this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
			// 
			// btnSapXep
			// 
			this.btnSapXep.Location = new System.Drawing.Point(331, 305);
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.Size = new System.Drawing.Size(126, 42);
			this.btnSapXep.TabIndex = 7;
			this.btnSapXep.Text = "Sắp xếp";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			// 
			// btnLamLai
			// 
			this.btnLamLai.Location = new System.Drawing.Point(487, 305);
			this.btnLamLai.Name = "btnLamLai";
			this.btnLamLai.Size = new System.Drawing.Size(126, 42);
			this.btnLamLai.TabIndex = 8;
			this.btnLamLai.Text = "Làm lại";
			this.btnLamLai.UseVisualStyleBackColor = true;
			this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(643, 305);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(126, 42);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLamLai);
			this.Controls.Add(this.btnSapXep);
			this.Controls.Add(this.btnTinhTong);
			this.Controls.Add(this.btnNhap);
			this.Controls.Add(this.lblSapXep);
			this.Controls.Add(this.lblTong);
			this.Controls.Add(this.lblDaySo);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.lblN);
			this.Name = "Form1";
			this.Text = "Day so";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblDaySo;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

