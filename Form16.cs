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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ИльиныхDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.КлиентTableAdapter.Fill(this.ИльиныхDataSet.Клиент);
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
