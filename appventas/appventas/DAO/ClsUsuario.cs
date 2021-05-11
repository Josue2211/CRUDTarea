using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsUsuario
    {


        public List<tb_usuario> cargarDatosUser()
        {
            List<tb_usuario> Lista;

            using (sistema_ventasEntities sv = new sistema_ventasEntities())
            {
                Lista = sv.tb_usuario.ToList();
            }

            return Lista;
        }
        public void SaveDatosUser(tb_usuario tu)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_usuario user = new tb_usuario();

                    user.email = tu.email;
                    user.contrasena = tu.contrasena;
                    db.tb_usuario.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void DeleteUser(int ID)
        {

            try
            {
                using (sistema_ventasEntities sv = new sistema_ventasEntities())
                {

                    int Eliminar = Convert.ToInt32(ID);
                    tb_usuario tu = sv.tb_usuario.Where(x => x.iDUsuario == Eliminar).Select(x => x).FirstOrDefault();
                    sv.tb_usuario.Remove(tu);
                    sv.SaveChanges();
                    MessageBox.Show("Dato Eliminado");

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }
        public void UpdateUser(tb_usuario tb)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Update = Convert.ToInt32(tb.iDUsuario);
                    tb_usuario tu = db.tb_usuario.Where(x => x.iDUsuario == Update).Select(x => x).FirstOrDefault();
                    tu.email = tb.email;
                    tu.contrasena = tb.contrasena;
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }
    }
}




