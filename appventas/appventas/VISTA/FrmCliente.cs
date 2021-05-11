using appventas.DAO;
using appventas.MODEL;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            Carga();
            Clear();
        }
        void Clear()
        {
            txtID.Clear();
            txtNombreCli.Clear();
            txtDireccionClien.Clear();
            txtDUI.Clear();
        }
         void Carga()
        {
            dtgCliente.Rows.Clear();
            ClsCliente clsClient = new ClsCliente();
            List<tb_cliente> Lista = clsClient.cargarDatosCliente();


            foreach (var iteraction in Lista)
            {
                dtgCliente.Rows.Add(iteraction.iDCliente, iteraction.nombreCliente, iteraction.direccionCliente, iteraction.duiCliente);
            }
        }
        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtgCliente.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgCliente.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dtgCliente.CurrentRow.Cells[2].Value.ToString();
            String DUI = dtgCliente.CurrentRow.Cells[3].Value.ToString();

            txtID.Text = ID;
            txtNombreCli.Text = Nombre;
            txtDireccionClien.Text = Direccion;
            txtDUI.Text = DUI;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsCliente clsCliente = new ClsCliente();
            tb_cliente client = new tb_cliente();
            client.nombreCliente = txtNombreCli.Text;
            client.direccionCliente = txtDireccionClien.Text;
            client.duiCliente = txtDUI.Text;
            clsCliente.SaveDatosClient(client);

            Carga();
            Clear();

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {


            ClsCliente tc = new ClsCliente();
            tc.DeleteClient(Convert.ToInt32(txtID.Text));
            Carga();
            Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
                ClsCliente clsCliente = new ClsCliente();

                tb_cliente tb = new tb_cliente();
                tb.iDCliente = Convert.ToInt32(txtID.Text);
                tb.nombreCliente = txtNombreCli.Text;
                tb.direccionCliente = txtDireccionClien.Text;
                tb.duiCliente = txtDUI.Text;
                clsCliente.UpdateClient(tb);


            }

            Carga();
            Clear();
        }
    }
}

