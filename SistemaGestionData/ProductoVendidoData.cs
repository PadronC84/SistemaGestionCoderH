using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class ProductoVendidoData
    {
        private readonly AppDbContext dbContext;
        
        public ProductoVendidoData(AppDbContext context)
        {
            dbContext = context;
        }

        public List<ProductoVendido> GetProductoVendidos()
        {
            return dbContext.ProductosVendidos.ToList();
        }

        public void CrearProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            if (nuevoProductoVendido.IdProducto == 0) { nuevoProductoVendido.IdProducto = 1; }
            if (nuevoProductoVendido.Stock == 0) { nuevoProductoVendido.Stock = 1; }
            if (nuevoProductoVendido.IdVenta == 0) { nuevoProductoVendido.IdVenta = 1; }

            dbContext.ProductosVendidos.Add(nuevoProductoVendido);
            dbContext.SaveChanges();
        }

        public void EditarProductoVendido(int productovendido)
        {
            dbContext.Entry(productovendido).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void EliminarProductoVendido(int Idproductovendido)
        {
            var productovendido = dbContext.ProductosVendidos.FirstOrDefault(u => u.IdVenta == Idproductovendido); ;
            if (productovendido != null)
            {
                dbContext.ProductosVendidos.Remove(productovendido);
                dbContext.SaveChanges();    

            }
        }


    }
}
