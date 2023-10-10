using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        private readonly UsuarioData usuarioData;

        public UsuarioBussiness(UsuarioData usuarioData)
        {
            this.usuarioData = usuarioData;
        }

        public List<Usuario> GetUsuarios()
        {
            return usuarioData.GetUsuarios();
        }

        public void CrearUsuario(Usuario nuevoUsuario)
        {
            usuarioData.CrearUsuario(nuevoUsuario);
        }

        public void EditarUsuario(Usuario usuario)
        {
            usuarioData.EditarUsuario(usuario);
        }

        public void EliminarUsuario(int usuarioId)
        {
            try
            {
                usuarioData.EliminarUsuario(usuarioId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
            }
        }
    }
}
