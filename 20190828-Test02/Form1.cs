using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190828_Test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = "出勤時間は" + dt.ToString() + "です";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = "退勤時間は" + dt.ToString() + "です";
        }
    }
}
