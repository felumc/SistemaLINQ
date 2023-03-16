using System;
using Microsoft.IdentityModel.Protocols;
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
    public partial class FrmModificaUsuario : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listaUsuarios;
        public FrmModificaUsuario()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmModificaUsuario_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (usuarios usuario in lista)
            {
                cmbUsuarios.Items.Add(usuario.usuario);
            }
        }

        private void FrmModificaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //Show the selected user's data in the textboxes
            usuarios user = dataContext.usuarios.FirstOrDefault(us => us.usuario.Equals(cmbUsuarios.SelectedItem.ToString()));
            txtUsuario.Text = user.usuario;
            txtPassword.Text = user.passwd;
            cmbEstado.Text = user.estado;
            cmbTipoUsuario.Text = user.tipo_usuario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Take the selected user's data and modify it
            usuarios user = dataContext.usuarios.FirstOrDefault(us => us.usuario.Equals(cmbUsuarios.SelectedItem.ToString()));
            user.usuario = txtUsuario.Text;
            user.passwd = txtPassword.Text;
            user.estado = cmbEstado.Text;
            user.tipo_usuario = cmbTipoUsuario.Text;
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario modificado correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Clear the textboxes and comboboxes
            txtUsuario.Text = "";
            txtPassword.Text = "";
            cmbEstado.Text = "";
            cmbTipoUsuario.Text = "";
        }
    }
}
