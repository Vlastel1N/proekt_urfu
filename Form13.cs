using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Ильиных_Гостиница
{
    public partial class Form13 : Form
    {
        public string q = "";
        public string w = "";
        public string eee = "";
        public string n = "";
        public string m = "";
        public int qwe;
        string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
        public Form13()
        {
            InitializeComponent();
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                var dataAdapter = new SqlDataAdapter("Select * From Услугиклиента", connect);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand command = new SqlCommand("delete from [Услугиклиента] where[Услугиклиента].[id_услуги_клиента]= " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Услугиклиента] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button4.Enabled = true;
        }
        private void label2_Click(object sender, EventArgs e)
       {
       }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into [Услугиклиента] ([Услугиклиента].[id_услуги_клиента],[Услугиклиента].[id_клиента],[Услугиклиента].[id_услуги],[Услугиклиента].[Стоимость_услуг],[Услугиклиента].[Количество_услуг]) values('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", connection);
                    command.ExecuteNonQuery();
                    SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Услугиклиента] ", connection);
                    DataTable data = new DataTable();
                    command1.Fill(data);
                    dataGridView1.DataSource = data;
                }
                textBox5.Clear(); textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                button4.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlDataReader Reader = new SqlCommand("Select * from [Услугиклиента] where [Услугиклиента].[id_услуги_клиента]= '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", connect).ExecuteReader();
                Reader.Read();
                q = Reader.GetValue(1).ToString();
                w = Reader.GetValue(2).ToString();
                eee = Reader.GetValue(3).ToString();
                n = Reader.GetValue(4).ToString();
                m = Reader.GetValue(5).ToString();
                qwe = Convert.ToInt32(eee) * Convert.ToInt32(n);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                new SqlCommand("update [Услугиклиента] set [id_клиента] = '" + q + "',[id_услуги]='" + w + "',[Стоимость_услуг]='" + eee + "',[Количество_услуг]='" + n + "',[К_оплате]='" + qwe + "' where [id_услуги_клиента] = '" + sellt + "'", connection).ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Услугиклиента]", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.ShowDialog(); ; 
        }
    }
}

