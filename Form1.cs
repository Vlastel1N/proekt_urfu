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
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=307WRK08\SQLEXPRESS; Initial Catalog=Ильиных;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select * from [Авторизация] where [Авторизация].[Логин]='"
                        + textBox1.Text + "' and [Авторизация].[Пароль]='" + textBox2.Text + "'", connection); 
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string rol = reader.GetValue(3).ToString();
                            MessageBox.Show("Добро пожаловать: " + rol);

                            switch (rol)
                            {
                                case "Директор":
                                    Form9 f = new Form9(); f.Show(); this.Hide();
                                    break;
                                    this.Close();
                                    Form1 f1 = new Form1();
                                    f1.Show();
                                case "Менеджер":
                                    Form6 a = new Form6(); a.Show(); this.Hide();
                                    break;
                                    this.Close();
                                    Form1 a1 = new Form1();
                                    a1.Show();
                                case "Бухгалтер":
                                    Form10 v = new Form10(); v.Show(); this.Hide();
                                    break;
                                    this.Close();
                                    Form1 v1 = new Form1();
                                    v1.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя нет");
                    }

                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 a8 = new Form8();
            a8.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into [Авторизация] ([Авторизация].[Логин],[Авторизация].[Пароль], [Авторизация].[Должность]) values ('"
                        + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (MessageBox.Show("Пользователь добавлен") == DialogResult.OK)
                    {
                        Form1 f1 = new Form1(); f1.Show(); this.Hide();
                    };
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
            this.Close();
        }
    }
}

