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
    public partial class FrmAgregaTrabajador : Form
    {
        DataClasses1DataContext dataContext;
        public FrmAgregaTrabajador()
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

        private void FrmAgregaTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            trabajador datos = new trabajador();
            datos.nombre = txtNombre.Text;
            datos.apellido_pat = txtApePat.Text;
            datos.apellido_mat = txtApeMat.Text;
            datos.direccion = txtDireccion.Text;
            datos.telefono = txtTelefono.Text;
            datos.num_empleado = Convert.ToInt32(txtNoEmpleado.Text);
            datos.id_usuario = Convert.ToInt32(cmbIdUsuario.Text);
            datos.id_puesto = Convert.ToInt32(cmbIdPuesto.Text);
            dataContext.trabajador.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador agregado correctamente");
        }

        private void FrmAgregaTrabajador_Load(object sender, EventArgs e)
        {
            //List all the user id's on cmbIdUsuario
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (usuarios usuario in lista)
            {
                cmbIdUsuario.Items.Add(usuario.id);
            }
            //List all the puestos on cmbIdPuesto
            var lista2 = dataContext.puesto.OrderBy(x => x.id_puesto).ToList();
            foreach (puesto puesto in lista2)
            {
                cmbIdPuesto.Items.Add(puesto.id_puesto);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Clean the txt and cmb
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNoEmpleado.Text = "";
            cmbIdUsuario.Text = "";
            cmbIdPuesto.Text = "";
        }
    }
}
