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
    public partial class FrmEliminaUsuario : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listaUsuarios;
        public FrmEliminaUsuario()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmEliminaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FrmEliminaUsuario_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (usuarios usuario in lista)
            {
                cmbUsuarios.Items.Add(usuario.usuario);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Delete the selected user from the cmbUsuarios
            usuarios user = dataContext.usuarios.FirstOrDefault(us => us.usuario.Equals(cmbUsuarios.SelectedItem.ToString()));
            dataContext.usuarios.DeleteOnSubmit(user);
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario eliminado");
            cmbUsuarios.Items.Clear();
            cmbUsuarios.Text = "";
            FrmEliminaUsuario_Load(sender, e);
        }
    }
}
