using System;
using System.Windows.Forms;

namespace Parcial_final
{
    public partial class Asistencia : UserControl
    {
        public Asistencia()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    bool entrada = false;
                    if (comboBox1.SelectedIndex == 0)
                    {
                        entrada = false;
                    }
                    else
                    {
                        entrada = true;
                    }
                    string query = $"INSERT INTO REGISTRO(idUsuario, entrada, temperatura) " +
                                   $"VALUES(" +
                                   $"'{textBox1.Text}'," +
                                   $"'{entrada}'," +
                                   
                                   $"'{textBox2.Text}')";
                    ConexionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("Agregado exitosamente");
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
        }
        }
    }
