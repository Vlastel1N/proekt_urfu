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
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                var dataAdapter = new SqlDataAdapter("Select * From Клиент", connect);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter("select * from [Клиент] where [Имя] like '%" + textBox1.Text + "%' or [Фамилия] like'%" + textBox1.Text + "%' or [Отчество] like'%" + textBox1.Text + "%' or [Адрес] like'%" + textBox1.Text + "%'", connection);
                DataTable data = new DataTable();
                command.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                SqlCommand command = new SqlCommand("delete from [Клиент] where[Клиент].[id_клиента]= " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Клиент] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            textBox8.Visible = true;
            textBox8.Enabled = true;
            textBox7.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            textBox4.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            maskedTextBox3.Enabled = true;
            button4.Enabled = true;
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
                SqlCommand command = new SqlCommand("insert into [Клиент] ([Клиент].[id_клиента],[Клиент].[Фамилия],[Клиент].[Имя],[Клиент].[Отчество],[Клиент].[Пол],[Клиент].[Дата_рождения],[Клиент].[Адрес],[Клиент].[Телефон],[Клиент].[Паспортные_данные]) values('" + textBox8.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox4.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "')", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Клиент] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }

            textBox8.Clear(); textBox7.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); comboBox1.Text = ""; maskedTextBox1.Clear(); maskedTextBox2.Clear(); maskedTextBox3.Clear();

            textBox8.Enabled = false;
            textBox7.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            button4.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
}

        private void button5_Click(object sender, EventArgs e)
        {
            try
            { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                new SqlCommand("update [Клиент] set [Фамилия] = '" + textBox7.Text + "', [Имя]='" + textBox2.Text + "', [Отчество]='" + textBox3.Text + "', [Пол]='" + comboBox1.Text + "', [Дата_рождения]='" + maskedTextBox1.Text + "', [Адрес]='" + textBox4.Text + "', [Телефон]='" + maskedTextBox2.Text + "', [Паспортные_данные]='" + maskedTextBox3.Text + "' where [id_клиента] = '" + sellt + "'", connection).ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Клиент] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
            textBox7.Clear(); textBox2.Clear(); textBox3.Clear(); comboBox1.Text = ""; textBox4.Clear(); maskedTextBox1.Clear(); maskedTextBox2.Clear(); maskedTextBox3.Clear();

            label10.Visible = false;
            textBox8.Visible = false;
            textBox7.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            button5.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            textBox8.Visible = false;
            textBox7.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            textBox4.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            maskedTextBox3.Enabled = true;
            button5.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
