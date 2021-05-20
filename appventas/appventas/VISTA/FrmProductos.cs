using appventas.DAO;
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        void cargarDatos()
        {

            ClsProductos clsProductos = new ClsProductos();
            dtgProductos.Rows.Clear();
            //List<tb_producto> Lista = clsPro.cargarDatosProductoFiltro();


            foreach (var listarDatos in clsProductos.cargarDatosProductoFiltro(txtFiltro.Text))
            {
                dtgProductos.Rows.Add(listarDatos.idProducto, listarDatos.nombreProducto, listarDatos.precioProducto, listarDatos.estadoProducto);
            }
        }


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtgProductos.CurrentRow.Cells[2].Value.ToString();

            //FrmVentas frmventa = new FrmVentas();
            //frmventa.txtCodigoProd.Text = ID;
            //frmventa.txtNombreProd.Text = Nombre;
            //frmventa.txtPrecio.Text = Precio;
            //frmventa.Show();
            FrmMenuVenta.frmVenta.txtCodigoProd.Text = ID;
            FrmMenuVenta.frmVenta.txtNombreProd.Text = Nombre;
            FrmMenuVenta.frmVenta.txtPrecio.Text = Precio;

            this.Close();
        }
    }
}
