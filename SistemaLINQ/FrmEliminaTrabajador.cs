using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLINQ
{
    public partial class FrmEliminaTrabajador : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listaTrabajador;
        public FrmEliminaTrabajador()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmEliminaTrabajador_Load(object sender, EventArgs e)
        {
            //List all the trabajadores on cmbTrabajadores
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (trabajador trabajador in lista)
            {
                cmbTrabajadores.Items.Add(trabajador.nombre);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FrmEliminaTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Delete the selected trabajador from the cmbTrabajadores
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(trab => trab.nombre.Equals(cmbTrabajadores.SelectedItem.ToString()));
            dataContext.trabajador.DeleteOnSubmit(trabajador);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador eliminado");
            cmbTrabajadores.Items.Clear();
            cmbTrabajadores.Text = "";
            FrmEliminaTrabajador_Load(sender, e);
        }
    }
}
