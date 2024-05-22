using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class kasa : Form
    {

        public kasa()
        {
            InitializeComponent();
        }

        private void kasa_Load(object sender, EventArgs e)
        {
            
         

        }

    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string connectionString = "server=localhost;user=root;database=demirbas;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                
                connection.Open();

              
                string query = "SELECT * FROM kasabilgiler";
                MySqlCommand command = new MySqlCommand(query, connection);

                
                MySqlDataReader reader = command.ExecuteReader();

                
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString("isletimsistemi"); 
                    textBox2.Text = reader.GetString("ekran");
                    textBox3.Text = reader.GetString("ram");
                    textBox4.Text = reader.GetString("islemci");
                }

           
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından bilgileri çekerken bir hata oluştu: " + ex.Message);
            }
            finally
            {
               
                connection.Close();
            }
        }
    }
}
    

