using MarcosAntonioMejiaMirandaParcial2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarcosAntonioMejiaMirandaParcial2.Model;
using MarcosAntonioMejiaMirandaParcial2.Vista;

namespace MarcosAntonioMejiaMirandaParcial2.Vista
{
    public partial class fmrAdmin : Form
    {
        public fmrAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdmin.Text == "master" && txtContraseña.Text == "123")
            {
                MessageBox.Show("Bienvenido/a");
                frmDB B  = new frmDB();
                B.Show();
                this.Hide();
            }
        }
    }
}
