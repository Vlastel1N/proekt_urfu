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
    public partial class Form7 : Form
    {
        public string q ="";
        public string w ="";
        public string eee ="";
        public string n ="";
        public string m ="";
        public string y ="";
        public string a = "";
        public string b = "";
        public string c = "";
        public string j = "";
        public int qwe; public int qa; public int qb;
        string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                var dataAdapter = new SqlDataAdapter("Select * From Договор", connect);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                SqlCommand command = new SqlCommand("delete from [Договор] where[Договор].[id_договор]= " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Договор] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                SqlCommand command = new SqlCommand("insert into [Договор] ([Договор].[id_договор],[Договор].[id_клиента],[Договор].[id_номер],[Договор].[id_услуги_клиента],[Договор].[На_сколько_дней_заселять],[Договор].[Дата_заселения],[Договор].[Дата_выселения],[Договор].[Количество_проживающих],[Договор].[Стоимость_номера],[Договор].[Стоимость_услуги_к_оплате]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Договор] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox8.Text = ""; maskedTextBox1.Clear(); maskedTextBox2.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            button4.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlDataReader Reader = new SqlCommand("Select * from [Договор] where [Договор].[id_договор]= '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", connect).ExecuteReader();
                Reader.Read();
                q = Reader.GetValue(1).ToString();
                w = Reader.GetValue(2).ToString();
                eee = Reader.GetValue(3).ToString();
                n = Reader.GetValue(4).ToString();
                m = Reader.GetValue(5).ToString();
                y = Reader.GetValue(6).ToString();
                a = Reader.GetValue(7).ToString();
                b = Reader.GetValue(8).ToString();
                c = Reader.GetValue(9).ToString();
                j = Reader.GetValue(10).ToString();
                qwe = Convert.ToInt32(n) * Convert.ToInt32(b);
                qa = qwe * Convert.ToInt32(a);
                qb = qa + Convert.ToInt32(c);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                new SqlCommand("update [Договор] set [id_клиента] = '" + q + "',[id_номер]='" + w + "',[id_услуги_клиента]='" + eee + "',[На_сколько_дней_заселять]='" + n + "',[Дата_заселения]='" + m + "',[Дата_выселения]='" + y + "',[Количество_проживающих]='" + a + "',[Стоимость_номера]='" + b + "',[Стоимость_услуги_к_оплате]='" + c + "',[Общая_сумма]='" + qb + "' where [id_договор] = '" + sellt + "'", connection).ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Договор]", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            button6.Enabled = true;
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                new SqlCommand("update [Договор] set [id_клиента] = '" + textBox2.Text + "', [id_номер]='" + textBox3.Text + "', [id_услуги_клиента]='" + textBox4.Text + "', [На_сколько_дней_заселять]='" + textBox8.Text + "', [Дата_заселения]='" + maskedTextBox1.Text + "', [Дата_выселения]='" + maskedTextBox2.Text + "', [Количество_проживающих]='" + textBox5.Text + "', [Стоимость_номера]='" + textBox6.Text + "', [Стоимость_услуги_к_оплате]='" + textBox7.Text + "' where [id_договор] = '" + sellt + "'", connection).ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Договор] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox8.Text = ""; maskedTextBox1.Clear(); maskedTextBox2.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            button6.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

