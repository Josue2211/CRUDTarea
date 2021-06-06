using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsVenta
    {
        public List<tb_venta> Ultimaventa()
        {
            List<tb_venta> consultaUltimaVenta = new List<tb_venta>();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {

                consultaUltimaVenta = bd.tb_venta.ToList();
            }
            return consultaUltimaVenta;
        }
        public void guardado(tb_venta ventas)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_venta venta = new tb_venta();

                venta.iDDocumento = ventas.iDDocumento;
                venta.iDCliente = ventas.iDCliente;
                venta.iDUsuario = ventas.iDUsuario;
                venta.totalVenta = ventas.totalVenta;
                venta.fecha = ventas.fecha;
                bd.tb_venta.Add(venta);
                bd.SaveChanges();
            }
        }
    }
}

