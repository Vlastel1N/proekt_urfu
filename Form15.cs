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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ИльиныхDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.ДоговорTableAdapter.Fill(this.ИльиныхDataSet.Договор);
            this.reportViewer1.RefreshReport();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
