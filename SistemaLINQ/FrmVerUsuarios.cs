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
    public partial class FrmVerUsuarios : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listaUsuarios;
        public FrmVerUsuarios()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["SistemaLINQ.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmVerUsuarios_Load(object sender, EventArgs e)
        {
            //Add the users from dataContext to the DataGridView
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("usuario", "Usuario");
            dataGridView1.Columns.Add("passwd", "Contraseña");
            dataGridView1.Columns.Add("estado", "Estado");
            dataGridView1.Columns.Add("tipo_usuario", "Tipo de Usuario");
            foreach (usuarios usuario in lista)
            {
                dataGridView1.Rows.Add(usuario.id, usuario.usuario, usuario.passwd, usuario.estado, usuario.tipo_usuario);
            }
        }

        private void FrmVerUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }
    }
}
