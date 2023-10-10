using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SistemaGestionData;
using SistemaGestionEntities;


namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        private readonly ProductoVendidoData productovendidodata;
            
        public ProductoVendidoBussiness(ProductoVendidoData productovendidodata)
        {
            this.productovendidodata = productovendidodata;
        }

        public List<ProductoVendido> GetProductoVendidos()
        {
            return productovendidodata.GetProductoVendidos();
        }

        public  void CrearProductoVendido(ProductoVendido nuevoproductovendido)
        {
            productovendidodata.CrearProductoVendido(nuevoproductovendido);
        }

        public void EditarProductoVendido(int productovendido)
        {
            productovendidodata.EditarProductoVendido(productovendido);
        }

        public void EliminarProductoVendido(int Id)
        {
            try
            {
                productovendidodata.EliminarProductoVendido(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            {

            }
        }
    }
}
