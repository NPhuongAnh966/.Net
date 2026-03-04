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
			txtTongTien.ReadOnly = true; //chỉ xem ko đc nhập, vẫn đc gán code 

			rad5.Visible = false;
			rad10.Visible = false;
		}
		private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))  // chỉ đc nhập số
				e.Handled = true;
		}

		private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}

        private void chkGiamGia_CheckedChanged(object sender, EventArgs e)
        {
			if (chkGiamGia.Checked)
			{
				rad5.Visible = true; // khi chọn giảm giá thì mới đc chọn ô %
				rad10.Visible = true;
			}
			else
			{
				rad5.Visible = false;
				rad10.Visible = false;
				rad5.Checked = false;
				rad10.Checked = false;
			}
		}

        private void btnThucHien_Click(object sender, EventArgs e)
        {
			if (txtDonGia.Text == "" || txtSoLuong.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
				return;
			}

			double donGia = double.Parse(txtDonGia.Text);
			int soLuong = int.Parse(txtSoLuong.Text);

			double tong = donGia * soLuong;

			if (chkGiamGia.Checked)
			{
				if (rad5.Checked)
					tong *= 0.95;   // giảm 5%
				else if (rad10.Checked)
					tong *= 0.90;  // giảm 10%
			}

			txtTongTien.Text = tong.ToString();
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}
    }
}
