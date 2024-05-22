using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kullaniciTextbox.Text) ||
                string.IsNullOrWhiteSpace(sifreTextbox.Text))
            {
                MessageBox.Show("Lütfen boş kalan yerleri doldurunuz.");
                return;
            }

            string connectionString = "server=localhost;user=root;database=demirbas;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM giris WHERE kullanici=@kullanici AND sifre=@sifre";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@kullanici", kullaniciTextbox.Text);
                command.Parameters.AddWithValue("@sifre", sifreTextbox.Text);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Giriş Başarılı");

                  
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Girdiğiniz bilgiler ile veritabanındaki bilgiler uyuşmuyor. Lütfen bilgilerinizi kontrol edin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
