using System;
using System.Windows.Forms;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionUserInterface
{
    public partial class frmEditarUsuario : Form
    {
        private readonly Usuario usuario;
        private readonly UsuarioBussiness usuarioBussiness;

        public frmEditarUsuario(Usuario usuarioParametro, UsuarioBussiness usuarioBussinessParametro)
        {
            InitializeComponent();
            this.usuario = usuarioParametro;
            this.usuarioBussiness = usuarioBussinessParametro;
        }

        private void formEditarUsuario_Load(object sender, EventArgs e)
        {
            // Verifica si el usuario no es nulo
            if (usuario != null)
            {
                // Configura las columnas del DataGridView (si no lo has hecho en el diseñador)
                if (dgUsuario.Columns.Count == 0)
                {
                    dgUsuario.Columns.Add("Propiedad", "Propiedad");
                    dgUsuario.Columns.Add("Valor", "Valor");
                }

                // Agrega filas al DataGridView
                dgUsuario.Rows.Add("Nombre:", usuario.Nombre);
                dgUsuario.Rows.Add("Apellido:", usuario.Apellido);
                dgUsuario.Rows.Add("Nombre de Usuario:", usuario.NombreUsuario);
                dgUsuario.Rows.Add("Contraseña:", usuario.Contraseña);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombre.Text;
            string nuevoApellido = txtApellido.Text;
            string nuevoNombreUsuario = txtNombreUsuario.Text;
            string nuevaContraseña = txtContraseña.Text;

            // Actualiza el objeto usuario con los nuevos valores
            usuario.Nombre = nuevoNombre;
            usuario.Apellido = nuevoApellido;
            usuario.NombreUsuario = nuevoNombreUsuario;
            usuario.Contraseña = nuevaContraseña;

            // Guarda los cambios en la base de datos utilizando UsuarioBussiness
            usuarioBussiness.EditarUsuario(usuario);

            // Cerrar el formulario de edición
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
