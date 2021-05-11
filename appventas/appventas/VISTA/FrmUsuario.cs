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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            Carga();
            Clear();
        }

        void Clear()
        {
            txtID.Clear();
            txtEmail.Clear();
            txtContra.Clear();
 
        }
        void Carga()
        {
            dtgUsuarios.Rows.Clear();
            ClsUsuario clsuser = new ClsUsuario();
            List<tb_usuario> Lista = clsuser.cargarDatosUser();


            foreach (var iteraction in Lista)
            {
                dtgUsuarios.Rows.Add(iteraction.iDUsuario, iteraction.email, iteraction.contrasena);
            }
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Email = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Contra = dtgUsuarios.CurrentRow.Cells[2].Value.ToString();

            txtID.Text = ID;
            txtEmail.Text = Email;
            txtContra.Text = Contra;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsUsuario clsuser = new ClsUsuario();
            tb_usuario tu = new tb_usuario();
            tu.email = txtEmail.Text;
            tu.contrasena = txtContra.Text;
            clsuser.SaveDatosUser(tu);

            Carga();
            Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsUsuario tc = new ClsUsuario();
            tc.DeleteUser(Convert.ToInt32(txtID.Text));
            Carga();
            Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
                ClsUsuario clsuser = new ClsUsuario();

                tb_usuario tu = new tb_usuario();
                tu.iDUsuario= Convert.ToInt32(txtID.Text);
                tu.email = txtEmail.Text;
                tu.contrasena =txtContra.Text;
                clsuser.UpdateUser(tu);


            }

            Carga();
            Clear();
        }
    }
}
