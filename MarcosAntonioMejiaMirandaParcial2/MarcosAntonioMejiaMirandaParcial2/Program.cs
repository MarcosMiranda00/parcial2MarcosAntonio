using MarcosAntonioMejiaMirandaParcial2.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarcosAntonioMejiaMirandaParcial2.Model;
using MarcosAntonioMejiaMirandaParcial2.Vista;

namespace MarcosAntonioMejiaMirandaParcial2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
