using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsProducto
    {

        public List<tb_producto> cargarDatosProducto()
        {
            List<tb_producto> Lista;

            using (sistema_ventasEntities sv = new sistema_ventasEntities())
            {
                Lista = sv.tb_producto.ToList();
            }

            return Lista;
        }



        public void SaveDatosClient(tb_producto tp)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_producto pro = new tb_producto();

                    pro.nombreProducto = tp.nombreProducto;
                    pro.precioProducto = tp.precioProducto;
                    pro.estadoProducto = tp.estadoProducto;
                    db.tb_producto.Add(tp);
                    db.SaveChanges();
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        public void DeleteProducto(int ID)
        {

            try
            {
                using (sistema_ventasEntities sv = new sistema_ventasEntities())
                {

                    int Eliminar = Convert.ToInt32(ID);
                    tb_producto tp = sv.tb_producto.Where(x => x.idProducto == Eliminar).Select(x => x).FirstOrDefault();
                    sv.tb_producto.Remove(tp);
                    sv.SaveChanges();
                    MessageBox.Show("Dato Eliminado");

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }
        public void UpdatePro(tb_producto tp)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Update = Convert.ToInt32(tp.idProducto);
                    tb_producto tpro = db.tb_producto.Where(x => x.idProducto == Update).Select(x => x).FirstOrDefault();
                    tpro.nombreProducto = tp.nombreProducto;
                    tpro.precioProducto = tp.precioProducto;
                    tpro.estadoProducto = tp.estadoProducto;
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



