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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ИльиныхDataSet3.Услугиклиента". При необходимости она может быть перемещена или удалена.
            this.УслугиклиентаTableAdapter.Fill(this.ИльиныхDataSet3.Услугиклиента);
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
