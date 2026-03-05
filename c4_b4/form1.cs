using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c4
{
    public partial class Form1 : Form
    {
		double so1, so2;
		string phepToan;
		public Form1()
        {
            InitializeComponent();
        }
        private void btnSo_Click_1(object sender, EventArgs e)
        {
			Button btn = sender as Button;
			txtHienThi.Text += btn.Text;
		}
        private void btnTru_Click(object sender, EventArgs e)
        {
			so1 = double.Parse(txtHienThi.Text);
			phepToan = "-";
			txtHienThi.Clear();
		}
        private void btnNhan_Click(object sender, EventArgs e)
        {
			so1 = double.Parse(txtHienThi.Text);
			phepToan = "*";
			txtHienThi.Clear();
		}
        private void btnChia_Click(object sender, EventArgs e)
        {
			so1 = double.Parse(txtHienThi.Text);
			phepToan = "/";
			txtHienThi.Clear();
		}
        private void btnCong_Click(object sender, EventArgs e)
        {
			so1 = double.Parse(txtHienThi.Text);
			phepToan = "+";
			txtHienThi.Clear();
		}
        private void btnBang_Click(object sender, EventArgs e)
        {
			so2 = double.Parse(txtHienThi.Text);
			double ketQua = 0;

			switch (phepToan)
			{
				case "+":
					ketQua = so1 + so2;
					break;
				case "-":
					ketQua = so1 - so2;
					break;
				case "*":
					ketQua = so1 * so2;
					break;
				case "/":
					if (so2 == 0)
					{
						MessageBox.Show("Không thể chia cho 0");
						return;
					}
					ketQua = so1 / so2;
					break;
			}

			txtHienThi.Text = ketQua.ToString();
		}
        private void btnC_Click(object sender, EventArgs e)
		{
			txtHienThi.Clear();
		}

	}
}
