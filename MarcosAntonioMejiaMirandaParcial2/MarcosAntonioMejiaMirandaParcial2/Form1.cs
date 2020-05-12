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

namespace MarcosAntonioMejiaMirandaParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrAdmin L = new fmrAdmin();
            L.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using(gobEntities db = new gobEntities())
            {
                var lista = from usua in db.usuarios
                            where usua.DUI == textBox1.Text
                            select new
                            {
                                nombre = usua.Nombre
                            };
                if (lista.Count() > 0)
                {
                    foreach(var iterardatos in lista)
                    {
                        lblNombreper.Visible = true;
                        lblBeneficiario.Visible = true;
                        lblNombreper.Text = iterardatos.nombre; 
                    }

                }
                else 
                {
                    lblNombreper.Visible = false;
                    lblBeneficiario.Visible = true;
                    lblBeneficiario.Text = "No es beneficiario";
                }
            }
        }
    }
}
