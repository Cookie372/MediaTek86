using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _ = textLogin.Text;
            _ = textPassword.Text;

            string connectionString = "Server=localhost;Database=MediaTek86;User Id=root;Password=";
            using (SqlConnection connection = new SqlConnection(connectionString))
         
                connection.Open();
                {
                    // Connexion réussie
                    MessageBox.Show("Connexion réussie !");
                    // Redirirection vers la fenêtre de gestion du personnel
                    GestionPersonnel GestionPersonnel = new GestionPersonnel();
                    GestionPersonnel.Show();
                    this.Hide();
                }
            }
        }
    }
