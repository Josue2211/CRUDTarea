using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTA
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome uwu ");
            FrmCliente frm = new FrmCliente();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
            FrmDocumento frm = new FrmDocumento();
            frm.Show();
            this.Hide();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProduc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz ingresado");
            FrmProducto frm = new FrmProducto();
            frm.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz entrado");
            FrmUsuario frm = new FrmUsuario();
            frm.Show();
            this.Close();
        }
    }
}
