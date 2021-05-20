using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsProductos
    {
        public List<tb_producto> cargarDatosProductoFiltro(String filtro)
        {
            List<tb_producto> tb_Productos = new List<tb_producto>();

            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_Productos = (from listadProductos in bd.tb_producto
                                where listadProductos.nombreProducto.Contains(filtro)
                                select listadProductos).ToList();
            }

            return tb_Productos;

        }
    }
}
