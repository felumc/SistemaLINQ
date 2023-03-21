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
    public partial class FrmEliminaSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listaSueldos;
        public FrmEliminaSueldo()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmEliminaSueldo_Load(object sender, EventArgs e)
        {
            //List all the sueldos on cmbSueldos
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (sueldo sueldo in lista)
            {
                cmbSueldos.Items.Add(sueldo.id_sueldo);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Delete the selected sueldo from the cmbSueldos
            sueldo sueldo = dataContext.sueldo.FirstOrDefault(sueld => sueld.id_sueldo.Equals(cmbSueldos.SelectedItem.ToString()));
            dataContext.sueldo.DeleteOnSubmit(sueldo);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo eliminado");
            cmbSueldos.Items.Clear();
            cmbSueldos.Text = "";
            FrmEliminaSueldo_Load(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FrmEliminaSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
