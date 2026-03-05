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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với chương trình win form đầu tiên");
            MessageBox.Show("Chào mừng bạn", "a", MessageBoxButtons.OKCancel);
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Ban chua nhap so luong");
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Ban chua nhap don gia");
                txtDonGia.Focus();
                return;
            }
            try
            {
                float soluong = Convert.ToSingle(txtSoLuong.Text);
                float dongia = Convert.ToSingle(txtDonGia.Text);
                float thanhtien = soluong * dongia;
                lblTongTien.Text = thanhtien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tinh toan:" + ex.Message);
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chặn không cho nhập
            }
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chặn không cho nhập
            }
        }
    }
}
