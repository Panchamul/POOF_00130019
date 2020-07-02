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
            if (Program.activeUser.Type)
            {
                query = "SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser";
                
            }
            else
            {
                query = $"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser AND au.idUser = {Program.activeUser.Id.ToString()}";

            }
            var dt = ConexionDB.executeQuery(query);
            dataGridView1.DataSource = dt;
    }
}
}