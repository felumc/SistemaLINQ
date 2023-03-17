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

        }
    }
}
