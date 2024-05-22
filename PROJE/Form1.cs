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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void donanımToolStripMenuItem_Click(object sender, EventArgs e)
        {

            {




                donanım formDonanim = new donanım();

                formDonanim.Show();






            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            if (string.IsNullOrWhiteSpace(adTextBox.Text) ||
                string.IsNullOrWhiteSpace(soyadTextBox.Text) ||
                string.IsNullOrWhiteSpace(unvanTextBox.Text) ||
                string.IsNullOrWhiteSpace(sicilTextBox.Text) ||
                string.IsNullOrWhiteSpace(bolumTextBox.Text) ||
                string.IsNullOrWhiteSpace(epostaTextBox.Text) ||
                string.IsNullOrWhiteSpace(odanumarasiTextbox.Text) ||
                string.IsNullOrWhiteSpace(iseBaslamaTarihiDateTimePicker.Text))
            {
                MessageBox.Show("Lütfen boş kalan yerleri doldurunuz.");
                return;
            }

            string connectionString = "server=localhost;user=root;database=demirbas;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                
                string query = "SELECT * FROM donanim WHERE sicilNo=@sicilNo";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@sicilNo", sicilTextBox.Text);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    if (adTextBox.Text == reader["Ad"].ToString() &&
                        soyadTextBox.Text == reader["Soyad"].ToString() &&
                        unvanTextBox.Text == reader["Ünvan"].ToString() &&
                        bolumTextBox.Text == reader["Bolum"].ToString() &&
                        epostaTextBox.Text == reader["EPosta"].ToString() &&
                        odanumarasiTextbox.Text == reader["odaNumarasi"].ToString() &&
                        iseBaslamaTarihiDateTimePicker.Text == reader["iseBaslamaTarihi"].ToString())
                    {
                        MessageBox.Show("Bilgiler doğru. İşleme donanım sekmesinden devam edebilirsiniz.");
                        
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz bilgiler ile veritabanındaki bilgiler uyuşmuyor. Lütfen bilgilerinizi kontrol edin.");
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz sicil numarasına sahip kayıt bulunamadı.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }











        private void unvanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
