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
    public partial class FrmAgregaSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listaSueldos;
        public FrmAgregaSueldo()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbIdTrabajador.Text = "";
            cmbIdPuesto.Text = "";
            txtSueldo.Text = "";
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sueldo datos = new sueldo();
            datos.id_trabajador = Convert.ToInt32(cmbIdTrabajador.Text);
            datos.id_puesto = Convert.ToInt32(cmbIdPuesto.Text);
            datos.sueldo1 = Convert.ToInt32(txtSueldo.Text);
            dataContext.sueldo.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo agregado correctamente");
        }

        private void FrmAgregaSueldo_Load(object sender, EventArgs e)
        {
            //List all the puestos on cmbIdPuesto
            var lista = dataContext.puesto.OrderBy(x => x.id_puesto).ToList();
            foreach (puesto puesto in lista)
            {
                cmbIdPuesto.Items.Add(puesto.id_puesto);
            }
            //List all the trabajadores on cmbIdTrabajador
            var lista2 = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (trabajador trabajador in lista2)
            {
                cmbIdTrabajador.Items.Add(trabajador.id_trabajador);
            }
        }

        private void FrmAgregaSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
