using appventas.DAO;
using appventas.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsAcceso accs = new ClsAcceso();

            int valor = accs.acceso(txtUser.Text,txtPass.Text);
            if (valor == 1)
            {
                FrmPrincipal frm = new FrmPrincipal();
                MessageBox.Show("Bienvenido");
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
