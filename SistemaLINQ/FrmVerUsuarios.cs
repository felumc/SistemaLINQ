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
    public partial class FrmVerUsuarios : Form
    {
        public FrmVerUsuarios()
        {
            InitializeComponent();
        }

        private void FrmVerUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void FrmVerUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
