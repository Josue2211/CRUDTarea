using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsDocumento
    {
        public List<tb_documento> cargarDatosDocumento()
        {
            List<tb_documento> Lista;

            using (sistema_ventasEntities sv = new sistema_ventasEntities())
            {
                Lista = sv.tb_documento.ToList();
            }

            return Lista;
        }
        public void SaveDatosDoc(tb_documento tb)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_documento doc = new tb_documento();

                    doc.nombreDocumento = tb.nombreDocumento;
                    db.tb_documento.Add(doc);
                    db.SaveChanges();
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        public void DeleteDocumento(int ID)
        {

            try
            {
                using (sistema_ventasEntities sv = new sistema_ventasEntities())
                {

                    int Eliminar = Convert.ToInt32(ID);
                    tb_documento doc = sv.tb_documento.Where(x => x.iDDocumento == Eliminar).Select(x => x).FirstOrDefault();
                    sv.tb_documento.Remove(doc);
                    sv.SaveChanges();
                    MessageBox.Show("Dato Eliminado");

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        public void UpdateDoc(tb_documento td)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Update = Convert.ToInt32(td.iDDocumento);
                    tb_documento tc = db.tb_documento.Where(x => x.iDDocumento == Update).Select(x => x).FirstOrDefault();
                    tc.nombreDocumento = td.nombreDocumento;
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
 
