using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
        internal struct User
        {
            public int Id;
            public string Name;
            public string Lastname;
            public string Password;
            public int Type;
            public bool Entrada;
        }

        public static User activeUser = new User();
    }
}