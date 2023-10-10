using SistemaGestionBussiness;
using SistemaGestionEntities;


namespace SistemaGestionUserInterface
{
    public partial class frmGestion : Form
    {
        private readonly UsuarioBussiness usuarioBussiness;
        private readonly ProductoBussiness productoBussiness;
        public frmGestion(UsuarioBussiness usuarioBussiness, ProductoBussiness productoBussiness)
        {
            InitializeComponent();
            this.usuarioBussiness = usuarioBussiness;
            this.productoBussiness = productoBussiness;
        }

        private void ActualizarDataGridView()
        {
            // Limpia el contenido actual del DataGridView
            dgUsuarios.DataSource = null;
            dgUsuarios.Rows.Clear();

            // Vuelve a cargar los datos de usuarios desde la base de datos y asigna la lista al DataGridView
            List<Usuario> usuarios = usuarioBussiness.GetUsuarios();
            dgUsuarios.DataSource = usuarios;
        }

        private void formGestion_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioBussiness.GetUsuarios();
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = usuarios;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                NombreUsuario = nombreUsuario,
                Contraseña = contraseña,
            };

            usuarioBussiness.CrearUsuario(nuevoUsuario);

            ActualizarDataGridView();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;

                // Crear una instancia de formEditarUsuario pasando el usuario seleccionado y UsuarioBussiness
                using (frmEditarUsuario formEditar = new frmEditarUsuario(usuarioSeleccionado, usuarioBussiness))
                {
                    DialogResult resultado = formEditar.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        // Actualizar el DataGridView después de editar
                        ActualizarDataGridView();
                    }
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
            }

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El apellido no puede estar vacío.");
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;

            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgUsuarios.SelectedRows[0];
                Usuario usuarioSeleccionado = (Usuario)filaSeleccionada.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Llamar a la función para eliminar el usuario
                    usuarioBussiness.EliminarUsuario(usuarioSeleccionado.Id);

                    // Actualizar el DataGridView después de eliminar
                    ActualizarDataGridView();
                }
            }
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            frmEditarProducto formProductos = new frmEditarProducto(productoBussiness);
            formProductos.Show();
        }
    }
}