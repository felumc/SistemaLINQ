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
    public partial class FrmModificaSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listaSueldos;
        public FrmModificaSueldo()
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
            //Clear the comboboxes and texboxes
            cmbSueldos.Text = "";
            cmbIdTrabajador.Text = "";
            cmbIdPuesto.Text = "";
            txtSueldo.Text = "";
            
        }

        private void FrmModificaSueldo_Load(object sender, EventArgs e)
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
            //List all the sueldos on cmdSueldos
            var lista3 = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (sueldo sueldo in lista3)
            {
                cmbSueldos.Items.Add(sueldo.id_sueldo);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Take the selected sueldo's data and modify it
            sueldo datos = dataContext.sueldo.Where(x => x.id_sueldo == Convert.ToInt32(cmbSueldos.Text)).FirstOrDefault();
            datos.id_trabajador = Convert.ToInt32(cmbIdTrabajador.Text);
            datos.id_puesto = Convert.ToInt32(cmbIdPuesto.Text);
            datos.sueldo1 = Convert.ToInt32(txtSueldo.Text);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo modificado correctamente");
            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Show the selected sueldo's data on the textboxes
            sueldo datos = dataContext.sueldo.Where(x => x.id_sueldo == Convert.ToInt32(cmbSueldos.SelectedItem)).FirstOrDefault();
            cmbIdTrabajador.Text = datos.id_trabajador.ToString();
            cmbIdPuesto.Text = datos.id_puesto.ToString();
            txtSueldo.Text = datos.sueldo1.ToString();
        }

        private void FrmModificaSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
