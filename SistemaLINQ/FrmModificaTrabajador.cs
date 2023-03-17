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
    public partial class FrmModificaTrabajador : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listaTrabajador;
        public FrmModificaTrabajador()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmModificaTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FrmModificaTrabajador_Load(object sender, EventArgs e)
        {
            //List all the trabajadores on cmbTrabajadores
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (trabajador trabajador in lista)
            {
                cmbTrabajadores.Items.Add(trabajador.nombre);
            }
            //List all the user id's on cmbIdUsuario
            var lista2 = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (usuarios usuario in lista2)
            {
                cmbIdUsuario.Items.Add(usuario.id);
            }
            //List all the puestos on cmbIdPuesto
            var lista3 = dataContext.puesto.OrderBy(x => x.id_puesto).ToList();
            foreach (puesto puesto in lista3)
            {
                cmbIdPuesto.Items.Add(puesto.id_puesto);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Show the selected trabajador's data in the textboxes
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(tr => tr.nombre.Equals(cmbTrabajadores.SelectedItem.ToString()));
            txtNombre.Text = trabajador.nombre;
            txtApePat.Text = trabajador.apellido_pat;
            txtApeMat.Text = trabajador.apellido_mat;
            txtDireccion.Text = trabajador.direccion;
            txtTelefono.Text = trabajador.telefono;
            txtNoEmpleado.Text = trabajador.num_empleado.ToString();
            cmbIdUsuario.Text = trabajador.id_usuario.ToString();
            cmbIdPuesto.Text = trabajador.id_puesto.ToString();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Take the selected trabajador's data and modify it
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(tr => tr.nombre.Equals(cmbTrabajadores.SelectedItem.ToString()));
            trabajador.nombre = txtNombre.Text;
            trabajador.apellido_pat = txtApePat.Text;
            trabajador.apellido_mat = txtApeMat.Text;
            trabajador.direccion = txtDireccion.Text;
            trabajador.telefono = txtTelefono.Text;
            trabajador.num_empleado = int.Parse(txtNoEmpleado.Text);
            trabajador.id_usuario = int.Parse(cmbIdUsuario.Text);
            trabajador.id_puesto = int.Parse(cmbIdPuesto.Text);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador modificado");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Clear the textboxes and comboboxes
            txtNombre.Text = "";
            txtApePat.Text = "";
            txtApeMat.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNoEmpleado.Text = "";
            cmbIdUsuario.Text = "";
            cmbIdPuesto.Text = "";
            cmbTrabajadores.Text = "";
            
        }
    }
}
