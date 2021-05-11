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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
            Carga();
            Clear();

        }
        void Clear()
        {
            txtId.Clear();
            txtDocumento.Clear();

        }
        void Carga()
        {
            dtgDocumento.Rows.Clear();
            ClsDocumento clsDoc = new ClsDocumento();
            List<tb_documento> Lista = clsDoc.cargarDatosDocumento();


            foreach (var iteraction in Lista)
            {
                dtgDocumento.Rows.Add(iteraction.iDDocumento, iteraction.nombreDocumento);
            }
        
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {

        }

        private void dtgDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtgDocumento.CurrentRow.Cells[0].Value.ToString();
            String Documento = dtgDocumento.CurrentRow.Cells[1].Value.ToString();

            txtId.Text = ID;
            txtDocumento.Text = Documento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsDocumento clsDoc = new ClsDocumento();
            tb_documento doc = new tb_documento();
            doc.nombreDocumento = txtDocumento.Text;
            clsDoc.SaveDatosDoc(doc);

            Carga();
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDocumento clsD = new ClsDocumento();
            clsD.DeleteDocumento(Convert.ToInt32(txtId.Text));
            Carga();
            Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
                ClsDocumento clsCliente = new ClsDocumento();

                tb_documento tb = new tb_documento();
                tb.iDDocumento = Convert.ToInt32(txtId.Text);
                tb.nombreDocumento = txtDocumento.Text;
                clsCliente.UpdateDoc(tb);


            }

            Carga();
            Clear();
        }
    }
}
