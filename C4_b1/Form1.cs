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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			toolTip1.SetToolTip(txtA, "Nhập số nguyên");
			toolTip1.SetToolTip(txtB, "Nhập số nguyên");
		}

        private void btnTong_Click(object sender, EventArgs e)
        {
			if (txtA.Text == "" || txtB.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ 2 số!");
				return;
			}
			int a = int.Parse(txtA.Text);
			int b = int.Parse(txtB.Text);

			int min = Math.Min(a, b);
			int max = Math.Max(a, b);

			int tong = 0;
			for (int i = min; i <= max; i++)
			{
				tong += i;
			}

			lblKetQua.Text = "Tổng các số từ " + min + " đến " + max + " = " + tong;
		}

        private void LtnLamLai_Click(object sender, EventArgs e)
        {
			txtA.Clear();
			txtB.Clear();
			lblKetQua.Text = "";
			txtA.Focus();
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}
		private void txtA_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

	}
}
