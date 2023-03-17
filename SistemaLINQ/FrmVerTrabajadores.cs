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
    public partial class FrmVerTrabajadores : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listaTrabajador;
        public FrmVerTrabajadores()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmVerTrabajadores_Load(object sender, EventArgs e)
        {
            //Add the trabajadores from dataContext to the DataGridView
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            dataGridView1.Columns.Add("id_trabajador", "ID");
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("apellido_pat", "Apellido Paterno");
            dataGridView1.Columns.Add("apellido_mat", "Apellido Materno");
            dataGridView1.Columns.Add("direccion", "Direccion");
            dataGridView1.Columns.Add("telefono", "Telefono");
            dataGridView1.Columns.Add("num_empleado", "Numero de Empleado");
            dataGridView1.Columns.Add("id_usuario", "ID usuario");
            dataGridView1.Columns.Add("id_puesto", "ID puesto");
            foreach (trabajador trabajador in lista)
            {
                dataGridView1.Rows.Add(trabajador.id_trabajador, trabajador.nombre, trabajador.apellido_pat, trabajador.apellido_mat, trabajador.direccion, trabajador.telefono, trabajador.num_empleado, trabajador.id_usuario, trabajador.id_puesto);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void FrmVerTrabajadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
