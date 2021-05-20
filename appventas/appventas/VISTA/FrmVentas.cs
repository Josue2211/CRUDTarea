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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            //using (sistema_ventasEntities bd = new sistema_ventasEntities()) {


            //    var consultacliente = bd.tb_cliente.ToList();

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
    }
    }

