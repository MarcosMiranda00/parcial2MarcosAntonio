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
    public partial class frmDB : Form
    {
        public frmDB()
        {
            InitializeComponent();
        }
        usuarios user = new usuarios();

        void cargardatos()
        {
            using (gobEntities db = new gobEntities())
            {
                var usuarios = db.usuarios;
                foreach (var iterardatosUsuarios in usuarios)
                {
                    dataGridView1.Rows.Add(iterardatosUsuarios.id, iterardatosUsuarios.Nombre, iterardatosUsuarios.DUI);
                }

            }
        }

        void limpiardatos()
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                String Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(Id);
                user = db.usuarios.Where(VerificarId => VerificarId.id == idC).First();
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            dataGridView1.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {


                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;

                db.usuarios.Add(user);
                db.SaveChanges();
            }
            dataGridView1.Rows.Clear();
            cargardatos();
            limpiardatos();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                String Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                user = db.usuarios.Find(int.Parse(Id));
                db.usuarios.Remove(user);
                db.SaveChanges();
            }
            dataGridView1.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String DUI = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = Nombre;
            txtDUI.Text = DUI;
        }

        private void frmDB_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string DUI = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txtNombre.Text = nombre;
            txtDUI.Text = DUI;
        }
    }
}
