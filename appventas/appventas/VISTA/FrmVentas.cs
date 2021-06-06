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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }
        void Ultimocorrelativodeventa()
        {


            var consultaUltimaVenta = new ClsVenta();

            int lista = 0;

            foreach (var list in consultaUltimaVenta.Ultimaventa())
            {
                lista = list.iDVenta;

            }
            lista++;
            txtUltimaVenta.Text = lista.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

            Ultimocorrelativodeventa();

            ClsCliente clsCliente = new ClsCliente();

            comboBox2.DataSource = clsCliente.cargarDatosCliente();
            comboBox2.DisplayMember = "nombreCliente";
            comboBox2.ValueMember = "iDCliente";

            //var consultaDocumento = (from documento in bd.tb_documento
            //                        select new
            //                        {
            //                            documento.iDDocumento,
            //                            documento.nombreDocumento
            //                        }).ToList();

            //var consultaDocumento = bd.tb_documento.ToList();
            ClsDocumento clsDocumento = new ClsDocumento();
            comboBox1.DataSource = clsDocumento.cargarDatosDocumento();
            comboBox1.DisplayMember = "nombreDocumento";
            comboBox1.ValueMember = "iDDocumento";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProductos Buscar = new FrmProductos();
            Buscar.Show();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
        void calcular()
        {
            try
            {
                Double precio, cantidad, total;

                cantidad = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);

                total = precio * cantidad;

                txtTotal.Text = total.ToString();
            }
            catch (Exception Ex)
            {
                if (txtCantidad.Text.Equals(""))
                {
                    txtCantidad.Text = "0";
                    txtCantidad.SelectAll();
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            calcular();
            calculartotal();
            dtgVenta.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecio.Text, txtCantidad.Text, txtTotal.Text);

            txtCodigoProd.Clear();
            txtNombreProd.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();

            dtgVenta.Refresh();
            dtgVenta.ClearSelection();
            int ultimafila = dtgVenta.Rows.Count - 1;
            dtgVenta.FirstDisplayedScrollingRowIndex = ultimafila;
            dtgVenta.Rows[ultimafila].Selected = true;
        }

        private void txtBuscarPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (txtBuscarPro.Text.Equals(""))
                {
                    btnBuscar.PerformClick();
                    e.Handled = true;
                    //txtCant.Focus();

                }
                else
                {
                    e.Handled = true;
                    ClsProductos prod = new ClsProductos();
                    var busqueda = prod.BuscarProducto(Convert.ToInt32(txtBuscarPro.Text));

                    if (busqueda.Count < 1)
                    {

                        MessageBox.Show("No se han encontrado coincidencias");
                        txtBuscarPro.Text = "";

                    }
                    foreach (var iterar in busqueda)
                    {

                        txtCodigoProd.Text = iterar.idProducto.ToString();
                        txtNombreProd.Text = iterar.nombreProducto;
                        txtPrecio.Text = iterar.precioProducto.ToString();
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        txtBuscarPro.Text = "";
                    }
                }
        }
        void calculartotal()
        {
            Double suma = 0;
            for (int i = 0; i < dtgVenta.Rows.Count; i++)
            {

                //String Precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String datosaoperartotal = dtgVenta.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosaoperartotal);

                suma += DatosConvertidos;

                txtTotalFinal.Text = suma.ToString();


            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregar.PerformClick();
                e.Handled = true;
                txtBuscarPro.Focus();
            }
        }

        private void btnGuardarventa_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVenta ventas = new ClsVenta();
                tb_venta venta = new tb_venta();

                venta.iDDocumento = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                venta.fecha = Convert.ToDateTime(dateTimePicker1.Text);
                ventas.guardado(venta);


                ClsDetalle detalle = new ClsDetalle();
                tb_detalleVenta tbdetalle = new tb_detalleVenta();

                foreach (DataGridViewRow dtgv in dtgVenta.Rows)
                {
                    tbdetalle.idVenta = Convert.ToInt32(txtUltimaVenta.Text);
                    tbdetalle.idProducto = Convert.ToInt32(dtgv.Cells[0].Value.ToString());
                    tbdetalle.cantidad = Convert.ToInt32(dtgv.Cells[3].Value.ToString());
                    tbdetalle.precio = Convert.ToDecimal(dtgv.Cells[2].Value.ToString());
                    tbdetalle.total = Convert.ToDecimal(dtgv.Cells[4].Value.ToString());

                    detalle.guardardetalleventa(tbdetalle);
                }

                Ultimocorrelativodeventa();
                dtgVenta.Rows.Clear();
                txtTotalFinal.Text = "";


                MessageBox.Show("Save");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void dtgVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotal();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


