using System.Collections.Generic;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        private readonly ProductoData productoData;

        public ProductoBussiness(ProductoData productoData)
        {
            this.productoData = productoData;
        }

        public List<Producto> GetProductos()
        {
            
            return productoData.GetProductos();
        }

        public void CrearProducto(Producto nuevoProducto)
        {
            
            productoData.CrearProducto(nuevoProducto);
        }

        public void EditarProducto(Producto producto)
        {
           
            productoData.EditarProducto(producto);
        }

        public void EliminarProducto(int id)
        {
            
            productoData.EliminarProducto(id);
        }
    }
}
