using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System.Linq;

namespace SistemaGestionData
{
    public class ProductoData
    {
        private readonly AppDbContext dbContext;

        public ProductoData(AppDbContext context)
        {
            dbContext = context;
        }

        public List<Producto> GetProductos()
        {
            return dbContext.Productos.ToList();
        }

        public void CrearProducto(Producto nuevoProducto)
        {
            // Aplicar reglas de validación o ajustes necesarios antes de crear el producto
            nuevoProducto.Descripcion ??= "Sin Descripción";
            nuevoProducto.Costo = Math.Max(nuevoProducto.Costo, 0);
            nuevoProducto.PrecioVenta = Math.Max(nuevoProducto.PrecioVenta, 0);
            nuevoProducto.Stock = Math.Max(nuevoProducto.Stock, 0);
            nuevoProducto.IdUsuario = Math.Max(nuevoProducto.IdUsuario, 0);

            dbContext.Productos.Add(nuevoProducto);
            dbContext.SaveChanges();
        }

        public void EditarProducto(Producto producto)
        {
            var existingProduct = dbContext.Productos.Find(producto.Id);

            if (existingProduct != null)
            {
                // Aplicar reglas de validación o ajustes necesarios antes de editar el producto
                existingProduct.Descripcion = producto.Descripcion ?? existingProduct.Descripcion;
                existingProduct.Costo = Math.Max(producto.Costo, 0);
                existingProduct.PrecioVenta = Math.Max(producto.PrecioVenta, 0);
                existingProduct.Stock = Math.Max(producto.Stock, 0);
                existingProduct.IdUsuario = Math.Max(producto.IdUsuario, 0);

                dbContext.Entry(existingProduct).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void EliminarProducto(int id)
        {
            var producto = dbContext.Productos.Find(id);
            if (producto != null)
            {
                dbContext.Productos.Remove(producto);
                dbContext.SaveChanges();
            }
        }
    }
}
