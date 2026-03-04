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
		int[] arr;
		int n;
		Random rd = new Random();
		public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
		private void txtN_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
        private void btnNhap_Click(object sender, EventArgs e)
        {
			if (txtN.Text == "")
			{
				MessageBox.Show("Vui lòng nhập n!");
				return;
			}

			n = int.Parse(txtN.Text);

			if (n <= 0)
			{
				MessageBox.Show("n phải > 0");
				return;
			}

			arr = new int[n];
			lblDaySo.Text = "Dãy số: ";

			for (int i = 0; i < n; i++)
			{
				arr[i] = rd.Next(1, 101);   // từ 1 đến 100
				lblDaySo.Text += arr[i] + " ";
			}

			lblTong.Text = "Tổng dãy số: ";
			lblSapXep.Text = "Sắp xếp: ";
		}

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
			if (arr == null)
			{
				MessageBox.Show("Vui lòng nhập dãy số trước!");
				return;
			}

			int tong = 0;

			foreach (int x in arr)
			{
				tong += x;
			}

			lblTong.Text = "Tổng dãy số: " + tong;
		}

        private void btnSapXep_Click(object sender, EventArgs e)
        {
			if (arr == null)
			{
				MessageBox.Show("Vui lòng nhập dãy số trước!");
				return;
			}

			Array.Sort(arr);

			lblSapXep.Text = "Sắp xếp: ";

			foreach (int x in arr)
			{
				lblSapXep.Text += x + " ";
			}
		}

        private void btnLamLai_Click(object sender, EventArgs e)
        {
			txtN.Clear();
			lblDaySo.Text = "Dãy số: ";
			lblTong.Text = "Tổng dãy số: ";
			lblSapXep.Text = "Sắp xếp: ";
			arr = null;
			txtN.Focus();
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}
    }
}
