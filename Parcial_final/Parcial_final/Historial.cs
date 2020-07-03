using System;
using System.Windows.Forms;

namespace Parcial_final
{
    public partial class Historial : UserControl
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            LoadDataToTables();
        }
        private void LoadDataToTables()
        {
            string query = "";
            var dt = ConexionDB.executeQuery(
                $"SELECT * FROM REGISTRO where idUsuario = '{Program.activeUser.Id.ToString()}'");
            dataGridView1.DataSource = dt;
    }
}
}