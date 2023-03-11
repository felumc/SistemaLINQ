using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLINQ
{
    public partial class FrmAgregaUsuario : Form
    {
        
        public FrmAgregaUsuario()
        {
            InitializeComponent();
        }

        private void FrmAgregaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void FrmAgregaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            cmbTipoUsuario.Text = "";
            cmbEstado.Text = "";
        }
    }
}
