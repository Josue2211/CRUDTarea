using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.DAO
{
    class ClsCliente
    {

        public List<tb_cliente> cargarDatosCliente()
        {
            List<tb_cliente> Lista ;

            using (sistema_ventasEntities sv = new sistema_ventasEntities())
            {
                Lista = sv.tb_cliente.ToList();
            }

            return Lista;
        }



        public void SaveDatosClient(tb_cliente tb)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {

                    tb_cliente client = new tb_cliente();

                    client.nombreCliente = tb.nombreCliente;
                    client.direccionCliente = tb.direccionCliente;
                    client.duiCliente = tb.duiCliente;
                    db.tb_cliente.Add(client);
                    db.SaveChanges();
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        public void DeleteClient (int ID)
        {

            try
            {
                using (sistema_ventasEntities sv = new sistema_ventasEntities())
                {

                    int Eliminar = Convert.ToInt32(ID);
                    tb_cliente tb = sv.tb_cliente.Where(x => x.iDCliente == Eliminar).Select(x => x).FirstOrDefault();
                    sv.tb_cliente.Remove(tb);
                    sv.SaveChanges();
                    MessageBox.Show("Dato Eliminado");

                }
        
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        public void UpdateClient(tb_cliente tb)
        {

            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    int Update = Convert.ToInt32(tb.iDCliente);
                    tb_cliente tc = db.tb_cliente.Where(x => x.iDCliente == Update).Select(x => x).FirstOrDefault();
                    tc.nombreCliente = tb.nombreCliente;
                    tc.direccionCliente = tb.direccionCliente;
                    tc.duiCliente = tb.duiCliente;
                    db.SaveChanges();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
        //public List<tb_cliente> cargarComboCliente()
        //{

        //}

    }
}









