using System;
using System.Windows.Forms;

namespace Parcial_final
{
    public partial class Main : Form
    {
        private UserControl current = null;
        public Main()
        {
            InitializeComponent();
            current = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Historial();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Asistencia();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Editar();
            current.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(current, 1, 0);
            tableLayoutPanel1.SetRowSpan(current, 4);  
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (Program.activeUser.Type == 2)
            {
                button3.Visible = false;
            }
            else if(Program.activeUser.Type == 1 || Program.activeUser.Type >= 4)
            {
                button2.Visible = false;
                button3.Visible = false;
                
            }
        }
    }
}