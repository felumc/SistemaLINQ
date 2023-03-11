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
    public partial class FrmModificaUsuario : Form
    {
        public FrmModificaUsuario()
        {
            InitializeComponent();
        }

        private void FrmModificaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void FrmModificaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
