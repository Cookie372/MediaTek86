using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string password = textPassword.Text;

            // Implémentez ici la logique de vérification du login et mot de passe
            // par exemple, vous pouvez les comparer avec des valeurs prédéfinies ou les vérifier avec une base de données.

            if (login == "admin" && password == "123456")
            {
                // Connexion réussie
                MessageBox.Show("Connexion réussie !");
                // Ajoutez ici le code pour rediriger vers une autre fenêtre ou effectuer d'autres actions après la connexion réussie.
            }
            else
            {
                // Identifiants incorrects
                MessageBox.Show("Identifiants incorrects. Veuillez réessayer.");
            }
        }
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
