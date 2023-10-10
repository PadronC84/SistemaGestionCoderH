namespace SistemaGestionUserInterface
{
    partial class frmEditarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridProducto = new DataGridView();
            txtDescripcion = new RichTextBox();
            txtCosto = new TextBox();
            txtStock = new NumericUpDown();
            txtPrecioVenta = new TextBox();
            txtIdUsuario = new TextBox();
            lblDescripcion = new Label();
            lblPrecioVenta = new Label();
            lblCosto = new Label();
            lblStock = new Label();
            lblIdUsuario = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // dataGridProducto
            // 
            dataGridProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducto.Location = new Point(328, 51);
            dataGridProducto.Name = "dataGridProducto";
            dataGridProducto.RowTemplate.Height = 25;
            dataGridProducto.Size = new Size(460, 330);
            dataGridProducto.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(65, 69);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(229, 90);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.Text = "";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(65, 190);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(120, 23);
            txtCosto.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(65, 301);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(120, 23);
            txtStock.TabIndex = 3;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(65, 243);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(120, 23);
            txtPrecioVenta.TabIndex = 4;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(65, 358);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(120, 23);
            txtIdUsuario.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(65, 51);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(64, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Decripción";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(65, 225);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(72, 15);
            lblPrecioVenta.TabIndex = 7;
            lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(65, 172);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(38, 15);
            lblCosto.TabIndex = 8;
            lblCosto.Text = "Costo";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(65, 283);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(65, 340);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(60, 15);
            lblIdUsuario.TabIndex = 10;
            lblIdUsuario.Text = "Id Usuario";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(65, 407);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(146, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(328, 387);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(109, 48);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblStock);
            Controls.Add(lblCosto);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblDescripcion);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtStock);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(dataGridProducto);
            Name = "frmEditarProducto";
            Text = "Producto";
            Load += formEditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProducto;
        private RichTextBox txtDescripcion;
        private TextBox txtCosto;
        private NumericUpDown txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtIdUsuario;
        private Label lblDescripcion;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblStock;
        private Label lblIdUsuario;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnBorrar;
    }
}