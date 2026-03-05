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
			nudA.Minimum = -100;
			nudA.Maximum = 100;

			nudB.Minimum = -100;
			nudB.Maximum = 100;

			nudC.Minimum = -100;
			nudC.Maximum = 100;
		}

        private void btnGiai_Click(object sender, EventArgs e)
        {
			double a = (double)nudA.Value;
			double b = (double)nudB.Value;
			double c = (double)nudC.Value;

			if (a == 0)
			{
				MessageBox.Show("Đây không phải phương trình bậc 2");
				return;
			}

			double delta = b * b - 4 * a * c;
			txtKetQua.Text = "A = " + a +
				   "\r\nB = " + b +
				   "\r\nC = " + c;
			if (delta < 0)
			{
				txtKetQua.Text += "\r\nPhương trình vô nghiệm";
				txtX1.Text = "";
				txtX2.Text = "";
			}
			else if (delta == 0)
			{
				double x = -b / (2 * a);
				txtX1.Text = x.ToString();
				txtX2.Text = x.ToString();
				txtKetQua.Text += "\r\nPhương trình có nghiệm kép";
			}
			else
			{
				double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
				double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

				txtX1.Text = x1.ToString("0.##");
				txtX2.Text = x2.ToString("0.##");

				txtKetQua.Text += "\r\nPhương trình có 2 nghiệm phân biệt";
			}
		}

        private void btnThoat_Click(object sender, EventArgs e)
        {
			this.Close();
		}
    }
}
