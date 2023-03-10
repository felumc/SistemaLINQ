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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregaUsuario frmAgrega = new FrmAgregaUsuario();
            frmAgrega.Show();
            this.Hide();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminaUsuario frmElimina = new FrmEliminaUsuario();
            frmElimina.Show();
            this.Hide();
        }
    }
}
