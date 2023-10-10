using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        private readonly AppDbContext dbContext;

        public UsuarioData(AppDbContext context)
        {
            dbContext = context;
        }

        public List<Usuario> GetUsuarios()
        {
           
            return dbContext.Usuarios.ToList();
        }

        public void CrearUsuario(Usuario nuevoUsuario)
        {
            
            if (nuevoUsuario.Nombre == null)
            {
                nuevoUsuario.Nombre = "Sin Nombre";
            }
            if (nuevoUsuario.Apellido == null)
            {
                nuevoUsuario.Apellido = "Sin Apellido";
            }
            if (nuevoUsuario.NombreUsuario == null)
            {
                nuevoUsuario.NombreUsuario = "Sin Nombre de usuario";
            }
            if (nuevoUsuario.Contraseña == null)
            {
                nuevoUsuario.Contraseña = "Sin Contraseña";
            }

            dbContext.Usuarios.Add(nuevoUsuario);
            dbContext.SaveChanges();
        }

        public void EditarUsuario(Usuario usuario)
        {
            Debug.WriteLine($"Antes de actualizar: Nombre={usuario.Nombre}, Apellido={usuario.Apellido}, NombreUsuario={usuario.NombreUsuario}, Contraseña={usuario.Contraseña}");

            dbContext.Entry(usuario).State = EntityState.Modified;
            dbContext.SaveChanges();
            Debug.WriteLine("Cambios guardados correctamente");
        }

        public void EliminarUsuario(int usuarioId)
        {
            var usuario = dbContext.Usuarios.FirstOrDefault(u => u.Id == usuarioId);

            if (usuario != null)
            {
                dbContext.Usuarios.Remove(usuario);
                dbContext.SaveChanges();
            }
        }
    }
}
