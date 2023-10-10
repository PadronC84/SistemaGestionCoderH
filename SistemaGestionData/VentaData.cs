using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class VentaData
    {
        private readonly AppDbContext dbContext;
        public VentaData(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Venta> GetVentas()
        {
            return dbContext.Ventas.ToList();
        }

        public void CrearVenta(Venta nuevaVenta)
        {
            if (nuevaVenta.Comentarios == null) {nuevaVenta.Comentarios = "Sin comentarios";}
//if (nuevaVenta.IdUsuario == string.Empty) { nuevaVenta.IdUsuario = 0; }
            dbContext.Ventas.Add(nuevaVenta);
            dbContext.SaveChanges();
        }

        public void EditarVenta(Venta venta) 
        {
        dbContext.Entry(venta).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void EliminarVenta(int IdVenta)
        {
            var venta = dbContext.Ventas.FirstOrDefault(u => u.Id == IdVenta);
            if (venta != null)
            { dbContext.Ventas.Remove(venta); dbContext.SaveChanges();}
        }

    }
}
