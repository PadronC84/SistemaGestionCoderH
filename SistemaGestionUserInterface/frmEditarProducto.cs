using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUserInterface
{
    public partial class frmEditarProducto : Form
    {
        private readonly ProductoBussiness productoBussiness;

        public frmEditarProducto(ProductoBussiness productoBussiness)
        {
            InitializeComponent();
            this.productoBussiness = productoBussiness;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void formEditarProducto_Load(object sender, EventArgs e)
        {
            var listaProductos = productoBussiness.GetProductos();
            dataGridProducto.DataSource = listaProductos;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            decimal costo = decimal.Parse(txtCosto.Text);
            decimal precioVenta = decimal.Parse(txtPrecioVenta.Text);
            int stock = (int)txtStock.Value; ;
            int idUsuario = int.Parse(txtIdUsuario.Text);

            Producto nuevoProducto = new Producto
            {
                Descripcion = descripcion,
                Costo = costo,
                PrecioVenta = precioVenta,
                Stock = stock,
                IdUsuario = idUsuario
            };

            productoBussiness.CrearProducto(nuevoProducto);

            MessageBox.Show("Producto guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridProducto.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridProducto.SelectedRows[0];
                    int idProducto = (int)filaSeleccionada.Cells["Id"].Value;

                    DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Llamar al método EliminarProducto de ProductoBussiness para eliminar el producto
                        productoBussiness.EliminarProducto(idProducto);

                        // Actualizar el DataGridView en formGestion para mostrar los productos actualizados

                        MessageBox.Show("Producto eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un producto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
