using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_final
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
     try
            {
                string query = $"SELECT EXISTS(SELECT * FROM USUARIO WHERE idUsuario = '{textBox1.Text}'" +
                               $"AND password = '{textBox2.Text}')";
                var dt = ConexionDB.executeQuery(query);

                string quer = $"SELECT * FROM USUARIO WHERE idUsuario = '{textBox1.Text}'" +
                              $"AND password = '{textBox2.Text}'";

                    var dte = ConexionDB.executeQuery(quer);

                    Program.activeUser.Id = Convert.ToInt32(dte.Rows[0][0]);
                    Program.activeUser.Name = Convert.ToString(dte.Rows[0][1]);
                    Program.activeUser.Lastname = Convert.ToString(dte.Rows[0][2]);
                    Program.activeUser.Password = Convert.ToString(dte.Rows[0][3]);
                    Program.activeUser.Type = Convert.ToInt32(dte.Rows[0][4]);

                    this.Hide();
                    new Main().Show();
                
                
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error @.@");
            }
        }
    }
}