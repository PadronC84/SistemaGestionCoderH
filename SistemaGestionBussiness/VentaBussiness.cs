using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        private readonly VentaData ventadata;

        public VentaBussiness(VentaData ventadata)
        {
            this.ventadata = ventadata;
        }

        public List<Venta> GetVentas()
        {
            return ventadata.GetVentas();
        }

        public void CrearVenta(Venta nuevaVenta)
        {
            ventadata.CrearVenta(nuevaVenta);
        }

        public void EditarVenta(Venta venta)
        {
            ventadata.EditarVenta(venta);
        }

        public void EliminarVenta(int IdVenta)
        {
            try 
            {
                ventadata.EliminarVenta(IdVenta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar la venta: " + ex.Message);
            }
        }
    }
}
