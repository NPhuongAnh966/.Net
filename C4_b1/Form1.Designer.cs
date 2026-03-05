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
			this.components = new System.ComponentModel.Container();
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.btnTong = new System.Windows.Forms.Button();
			this.LtnLamLai = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(224, 121);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(99, 25);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Nhập a =";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(224, 172);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(99, 25);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "Nhập b =";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(348, 114);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(146, 31);
			this.txtA.TabIndex = 2;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(348, 165);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(146, 31);
			this.txtB.TabIndex = 3;
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Location = new System.Drawing.Point(224, 226);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(90, 25);
			this.lblKetQua.TabIndex = 4;
			this.lblKetQua.Text = "Kết Quả";
			// 
			// btnTong
			// 
			this.btnTong.Location = new System.Drawing.Point(195, 280);
			this.btnTong.Name = "btnTong";
			this.btnTong.Size = new System.Drawing.Size(97, 44);
			this.btnTong.TabIndex = 5;
			this.btnTong.Text = "Tổng";
			this.btnTong.UseVisualStyleBackColor = true;
			this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
			// 
			// LtnLamLai
			// 
			this.LtnLamLai.Location = new System.Drawing.Point(333, 279);
			this.LtnLamLai.Name = "LtnLamLai";
			this.LtnLamLai.Size = new System.Drawing.Size(104, 45);
			this.LtnLamLai.TabIndex = 6;
			this.LtnLamLai.Text = "Làm Lại";
			this.LtnLamLai.UseVisualStyleBackColor = true;
			this.LtnLamLai.Click += new System.EventHandler(this.LtnLamLai_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(487, 280);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(103, 44);
			this.btnThoat.TabIndex = 7;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.LtnLamLai);
			this.Controls.Add(this.btnTong);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Form1";
			this.Text = "Chuong trinh tinh tong";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button LtnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

