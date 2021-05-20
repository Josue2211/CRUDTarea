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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            Carga();
            Clear();
        }
        void Clear()
        {
            txtID.Clear();
            txtNombreP.Clear();
            txtPrecio.Clear();
            txtEstado.Clear();
        }
        void Carga()
        {
            dtgProducto.Rows.Clear();
            ClsProducto clsClient = new ClsProducto();
            List<tb_producto> Lista = clsClient.cargarDatosProducto();


            foreach (var iteraction in Lista)
            {
                dtgProducto.Rows.Add(iteraction.idProducto, iteraction.nombreProducto, iteraction.precioProducto, iteraction.estadoProducto);
            }
        
    }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsProducto clsPro = new ClsProducto();
            tb_producto tp = new tb_producto();
            tp.nombreProducto = txtNombreP.Text;
            tp.precioProducto = txtPrecio.Text;
            tp.estadoProducto = txtEstado.Text;
            clsPro.SaveDatosClient(tp);

            Carga();
            Clear();


        }

        private void dtgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtgProducto.CurrentRow.Cells[0].Value.ToString();
            String Producto = dtgProducto.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgProducto.CurrentRow.Cells[2].Value.ToString();
            String Estado = dtgProducto.CurrentRow.Cells[3].Value.ToString();

            txtID.Text = ID;
            txtNombreP.Text = Producto;
            txtPrecio.Text = Precio;
            txtEstado.Text = Estado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ClsProducto tc = new ClsProducto();
            tc.DeleteProducto(Convert.ToInt32(txtID.Text));
            Carga();
            Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsProducto clsCliente = new ClsProducto();

            tb_producto tp = new tb_producto();
            tp.idProducto = Convert.ToInt32(txtID.Text);
            tp.nombreProducto = txtNombreP.Text;
            tp.precioProducto = txtPrecio.Text;
            tp.estadoProducto = txtEstado.Text;
            clsCliente.UpdatePro(tp);

            {
                Carga();
                Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 