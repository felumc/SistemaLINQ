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
    public partial class FrmVerSueldos : Form
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listaSueldos;
        public FrmVerSueldos()
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

        private void FrmVerSueldos_Load(object sender, EventArgs e)
        {
            //Add the sueldos from dataContext to the DataGridView
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            dataGridView1.Columns.Add("id_sueldo", "ID");
            dataGridView1.Columns.Add("id_trabajador", "ID Trabajador");
            dataGridView1.Columns.Add("id_puesto", "ID Puesto");
            dataGridView1.Columns.Add("sueldo", "Sueldo");
            foreach (sueldo sueldo in lista)
            {
                dataGridView1.Rows.Add(sueldo.id_sueldo, sueldo.id_trabajador, sueldo.id_puesto, sueldo.sueldo1);
            }
        }

        private void FrmVerSueldos_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
