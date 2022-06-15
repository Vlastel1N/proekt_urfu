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
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;
Integrated Security=True";//=307WRK08\SQLEXPRESS; Initial Catalog = Гостиница_Ильиных; Integrated Security = True";
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox1.Enabled = false;

            textBox9.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            comboBox2.Enabled = true;
            button4.Enabled = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                var dataAdapter = new SqlDataAdapter("Select * From Сотрудники", connect);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            textBox5.Enabled = true;
            button2.Enabled = true;

            textBox9.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            comboBox2.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("insert into [Сотрудники] ([Сотрудники].[id_сотрудника],[Сотрудники].[Фамилия],[Сотрудники].[Имя],[Сотрудники].[Отчество],[Сотрудники].[Должность],[Сотрудники].[Зарплата]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+ comboBox1.Text + "','" + textBox5.Text + "')", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Сотрудники] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); comboBox1.Text=""; textBox5.Clear();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            textBox5.Enabled = false;
            button2.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            { 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                new SqlCommand("update [Сотрудники] set [Фамилия] = '" + textBox6.Text + "', [Имя]='" + textBox7.Text + "', [Отчество]='" + textBox8.Text + "', [Должность]='" + comboBox2.Text + "', [Зарплата]='" + textBox9.Text + "' where [id_сотрудника] = '" + sellt + "'", connection).ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Сотрудники] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }          
            textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); comboBox2.Text = "";
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            comboBox2.Enabled = false;
            button4.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки!");
            }
        }
         private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sellt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand command = new SqlCommand("delete from [Сотрудники] where[Сотрудники].[id_сотрудника]= " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", connection);
                command.ExecuteNonQuery();
                SqlDataAdapter command1 = new SqlDataAdapter("Select * from [Сотрудники] ", connection);
                DataTable data = new DataTable();
                command1.Fill(data);
                dataGridView1.DataSource = data;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {       
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {           
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

