using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ильиных_Гостиница
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a1 = new Form1();
            a1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 a15 = new Form15();
            a15.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 a8 = new Form8();
            a8.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
