using System;
using System.Windows.Forms;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionUserInterface;

namespace SistemaGestion
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var dbContext = new AppDbContext())
            {
                var usuarioData = new UsuarioData(dbContext);
                var productoData = new ProductoData(dbContext);
                var usuarioBussiness = new UsuarioBussiness(usuarioData);
                var productoBussiness = new ProductoBussiness(productoData);


                Application.Run(new frmGestion(usuarioBussiness, productoBussiness));
            }
        }
    }
}
