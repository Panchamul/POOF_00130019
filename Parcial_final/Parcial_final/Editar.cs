using System;
using System.Windows.Forms;

namespace Parcial_final
{
    public partial class Editar : UserControl
    {
        public Editar()
        {
            InitializeComponent();
        }
        private string idDepartamento = "0";
        private string idUser = "0";
        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        private void LoadDataToTables()
        {
            string query = $"SELECT idDepartamento from DEPARTAMENTO where nombre = '{comboBox1.Text.ToString()}'";
            var dr = ConexionDB.executeQuery(query);
            idDepartamento = dr.Rows[0][0].ToString();
            var dt = ConexionDB.executeQuery($"SELECT d.idDepartamentp, d.nombre FROM DEPARTAMENTO d WHERE idDepartamento = {idDepartamento} ");
            dataGridView3.DataSource = dt;
            var dtu = ConexionDB.executeQuery("SELECT * FROM USUARIO");
            dataGridView1.DataSource = dtu;
            var dtup = ConexionDB.executeQuery("SELECT * FROM REGISTRO");
            dataGridView2.DataSource = dtup;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" ||
                textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    LoadDataToTables();
                    string query = $"INSERT INTO USUARIO(idUsuario, idDepartamento,password,nombre,apellido,dui) " +
                                   $"VALUES(" +
                                   $"'{textBox1.Text}'," +
                                   $"'{idDepartamento}'," +
                                   $"'{textBox4.Text}'," +
                                   $"'{textBox2.Text}'," +
                                   $"'{textBox3.Text}'," +
                                   $"'{textBox5.Text}')";
                    ConexionDB.ExecuteNonQuery(query);


                    MessageBox.Show("Usuario agregado");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Seleccione el usuario que desea eliminar");
            }
            else
            {
                try
                {
                    ConexionDB.ExecuteNonQuery($"DELETE FROM Usuario WHERE idUsuario = {idUser}");

                    MessageBox.Show("El usuario fue eliminado");
                    LoadDataToTables();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacios");
            }
            else
            {
                try
                {
                    LoadDataToTables();
                    string query = $"INSERT INTO DEPARTAMENTO(nombre, ubicacion) " +
                                   $"VALUES(" +
                                   $"'{textBox6.Text}'," +
                                   $"{textBox7.Text})";
                    ConexionDB.ExecuteNonQuery(query);
                    

                    MessageBox.Show("departamento agregado");
                    LoadDataToTables();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error @.@");
                }
            }
        }
    }
}
