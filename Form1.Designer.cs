namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtPrecioAlta = new System.Windows.Forms.TextBox();
            this.lblPrecioAlta = new System.Windows.Forms.Label();
            this.txtStockAlta = new System.Windows.Forms.TextBox();
            this.lblStockAlta = new System.Windows.Forms.Label();
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.lblNombreAlta = new System.Windows.Forms.Label();
            this.txtIdAlta = new System.Windows.Forms.TextBox();
            this.lblIdAlta = new System.Windows.Forms.Label();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblDatosProducto = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.lblIdBuscar = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecioDatos = new System.Windows.Forms.TextBox();
            this.lblPrecioDatos = new System.Windows.Forms.Label();
            this.txtStockDatos = new System.Windows.Forms.TextBox();
            this.lblStockDatos = new System.Windows.Forms.Label();
            this.txtNombreDatos = new System.Windows.Forms.TextBox();
            this.lblNombreDatos = new System.Windows.Forms.Label();
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.btnMostrarPedidos = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.chkDescuento = new System.Windows.Forms.CheckBox();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.lblDatosPedido = new System.Windows.Forms.Label();
            this.lblSubtotalesPedido = new System.Windows.Forms.Label();
            this.txtCantidadPedido = new System.Windows.Forms.TextBox();
            this.lblCantidadPedido = new System.Windows.Forms.Label();
            this.cmbNombrePedido = new System.Windows.Forms.ComboBox();
            this.lblNombrePedido = new System.Windows.Forms.Label();
            this.grpAlta.SuspendLayout();
            this.grpProducto.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlta
            // 
            this.grpAlta.Controls.Add(this.btnAgregarProducto);
            this.grpAlta.Controls.Add(this.txtPrecioAlta);
            this.grpAlta.Controls.Add(this.lblPrecioAlta);
            this.grpAlta.Controls.Add(this.txtStockAlta);
            this.grpAlta.Controls.Add(this.lblStockAlta);
            this.grpAlta.Controls.Add(this.txtNombreAlta);
            this.grpAlta.Controls.Add(this.lblNombreAlta);
            this.grpAlta.Controls.Add(this.txtIdAlta);
            this.grpAlta.Controls.Add(this.lblIdAlta);
            this.grpAlta.Location = new System.Drawing.Point(12, 12);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Size = new System.Drawing.Size(284, 269);
            this.grpAlta.TabIndex = 0;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(102, 229);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtPrecioAlta
            // 
            this.txtPrecioAlta.Location = new System.Drawing.Point(47, 191);
            this.txtPrecioAlta.Name = "txtPrecioAlta";
            this.txtPrecioAlta.Size = new System.Drawing.Size(193, 20);
            this.txtPrecioAlta.TabIndex = 7;
            // 
            // lblPrecioAlta
            // 
            this.lblPrecioAlta.AutoSize = true;
            this.lblPrecioAlta.Location = new System.Drawing.Point(44, 175);
            this.lblPrecioAlta.Name = "lblPrecioAlta";
            this.lblPrecioAlta.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioAlta.TabIndex = 6;
            this.lblPrecioAlta.Text = "Precio";
            // 
            // txtStockAlta
            // 
            this.txtStockAlta.Location = new System.Drawing.Point(47, 139);
            this.txtStockAlta.Name = "txtStockAlta";
            this.txtStockAlta.Size = new System.Drawing.Size(193, 20);
            this.txtStockAlta.TabIndex = 5;
            // 
            // lblStockAlta
            // 
            this.lblStockAlta.AutoSize = true;
            this.lblStockAlta.Location = new System.Drawing.Point(44, 123);
            this.lblStockAlta.Name = "lblStockAlta";
            this.lblStockAlta.Size = new System.Drawing.Size(35, 13);
            this.lblStockAlta.TabIndex = 4;
            this.lblStockAlta.Text = "Stock";
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.Location = new System.Drawing.Point(47, 89);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.Size = new System.Drawing.Size(193, 20);
            this.txtNombreAlta.TabIndex = 3;
            // 
            // lblNombreAlta
            // 
            this.lblNombreAlta.AutoSize = true;
            this.lblNombreAlta.Location = new System.Drawing.Point(44, 73);
            this.lblNombreAlta.Name = "lblNombreAlta";
            this.lblNombreAlta.Size = new System.Drawing.Size(44, 13);
            this.lblNombreAlta.TabIndex = 2;
            this.lblNombreAlta.Text = "Nombre";
            // 
            // txtIdAlta
            // 
            this.txtIdAlta.Location = new System.Drawing.Point(47, 38);
            this.txtIdAlta.Name = "txtIdAlta";
            this.txtIdAlta.Size = new System.Drawing.Size(193, 20);
            this.txtIdAlta.TabIndex = 1;
            // 
            // lblIdAlta
            // 
            this.lblIdAlta.AutoSize = true;
            this.lblIdAlta.Location = new System.Drawing.Point(44, 21);
            this.lblIdAlta.Name = "lblIdAlta";
            this.lblIdAlta.Size = new System.Drawing.Size(16, 13);
            this.lblIdAlta.TabIndex = 0;
            this.lblIdAlta.Text = "Id";
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.btnEliminarProducto);
            this.grpProducto.Controls.Add(this.lstProductos);
            this.grpProducto.Controls.Add(this.lblDatosProducto);
            this.grpProducto.Location = new System.Drawing.Point(302, 12);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(284, 269);
            this.grpProducto.TabIndex = 1;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Lista de productos";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(102, 229);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(26, 54);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(241, 147);
            this.lstProductos.TabIndex = 1;
            // 
            // lblDatosProducto
            // 
            this.lblDatosProducto.AutoSize = true;
            this.lblDatosProducto.Location = new System.Drawing.Point(23, 38);
            this.lblDatosProducto.Name = "lblDatosProducto";
            this.lblDatosProducto.Size = new System.Drawing.Size(120, 13);
            this.lblDatosProducto.TabIndex = 0;
            this.lblDatosProducto.Text = "Id;Nombre;Stock;Precio";
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.btnLimpiar);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.txtIdBuscar);
            this.grpBuscar.Controls.Add(this.lblIdBuscar);
            this.grpBuscar.Controls.Add(this.grpDatos);
            this.grpBuscar.Location = new System.Drawing.Point(12, 287);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(574, 243);
            this.grpBuscar.TabIndex = 2;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(102, 136);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(102, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.Location = new System.Drawing.Point(50, 59);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(190, 20);
            this.txtIdBuscar.TabIndex = 4;
            // 
            // lblIdBuscar
            // 
            this.lblIdBuscar.AutoSize = true;
            this.lblIdBuscar.Location = new System.Drawing.Point(47, 42);
            this.lblIdBuscar.Name = "lblIdBuscar";
            this.lblIdBuscar.Size = new System.Drawing.Size(16, 13);
            this.lblIdBuscar.TabIndex = 3;
            this.lblIdBuscar.Text = "Id";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtPrecioDatos);
            this.grpDatos.Controls.Add(this.lblPrecioDatos);
            this.grpDatos.Controls.Add(this.txtStockDatos);
            this.grpDatos.Controls.Add(this.lblStockDatos);
            this.grpDatos.Controls.Add(this.txtNombreDatos);
            this.grpDatos.Controls.Add(this.lblNombreDatos);
            this.grpDatos.Location = new System.Drawing.Point(290, 19);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(267, 209);
            this.grpDatos.TabIndex = 2;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtPrecioDatos
            // 
            this.txtPrecioDatos.Location = new System.Drawing.Point(29, 159);
            this.txtPrecioDatos.Name = "txtPrecioDatos";
            this.txtPrecioDatos.Size = new System.Drawing.Size(198, 20);
            this.txtPrecioDatos.TabIndex = 5;
            // 
            // lblPrecioDatos
            // 
            this.lblPrecioDatos.AutoSize = true;
            this.lblPrecioDatos.Location = new System.Drawing.Point(26, 142);
            this.lblPrecioDatos.Name = "lblPrecioDatos";
            this.lblPrecioDatos.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioDatos.TabIndex = 4;
            this.lblPrecioDatos.Text = "Precio";
            // 
            // txtStockDatos
            // 
            this.txtStockDatos.Location = new System.Drawing.Point(29, 107);
            this.txtStockDatos.Name = "txtStockDatos";
            this.txtStockDatos.Size = new System.Drawing.Size(198, 20);
            this.txtStockDatos.TabIndex = 3;
            // 
            // lblStockDatos
            // 
            this.lblStockDatos.AutoSize = true;
            this.lblStockDatos.Location = new System.Drawing.Point(26, 90);
            this.lblStockDatos.Name = "lblStockDatos";
            this.lblStockDatos.Size = new System.Drawing.Size(35, 13);
            this.lblStockDatos.TabIndex = 2;
            this.lblStockDatos.Text = "Stock";
            // 
            // txtNombreDatos
            // 
            this.txtNombreDatos.Location = new System.Drawing.Point(29, 57);
            this.txtNombreDatos.Name = "txtNombreDatos";
            this.txtNombreDatos.Size = new System.Drawing.Size(198, 20);
            this.txtNombreDatos.TabIndex = 1;
            // 
            // lblNombreDatos
            // 
            this.lblNombreDatos.AutoSize = true;
            this.lblNombreDatos.Location = new System.Drawing.Point(26, 40);
            this.lblNombreDatos.Name = "lblNombreDatos";
            this.lblNombreDatos.Size = new System.Drawing.Size(44, 13);
            this.lblNombreDatos.TabIndex = 0;
            this.lblNombreDatos.Text = "Nombre";
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.btnMostrarPedidos);
            this.grpPedido.Controls.Add(this.btnCobrar);
            this.grpPedido.Controls.Add(this.btnAgregarItem);
            this.grpPedido.Controls.Add(this.chkDescuento);
            this.grpPedido.Controls.Add(this.lstPedidos);
            this.grpPedido.Controls.Add(this.lblDatosPedido);
            this.grpPedido.Controls.Add(this.lblSubtotalesPedido);
            this.grpPedido.Controls.Add(this.txtCantidadPedido);
            this.grpPedido.Controls.Add(this.lblCantidadPedido);
            this.grpPedido.Controls.Add(this.cmbNombrePedido);
            this.grpPedido.Controls.Add(this.lblNombrePedido);
            this.grpPedido.Location = new System.Drawing.Point(592, 12);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(284, 517);
            this.grpPedido.TabIndex = 3;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";
            // 
            // btnMostrarPedidos
            // 
            this.btnMostrarPedidos.Location = new System.Drawing.Point(181, 411);
            this.btnMostrarPedidos.Name = "btnMostrarPedidos";
            this.btnMostrarPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarPedidos.TabIndex = 10;
            this.btnMostrarPedidos.Text = "Mostrar";
            this.btnMostrarPedidos.UseVisualStyleBackColor = true;
            this.btnMostrarPedidos.Click += new System.EventHandler(this.btnMostrarPedidos_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(103, 411);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 9;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(22, 411);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarItem.TabIndex = 8;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // chkDescuento
            // 
            this.chkDescuento.AutoSize = true;
            this.chkDescuento.Location = new System.Drawing.Point(67, 351);
            this.chkDescuento.Name = "chkDescuento";
            this.chkDescuento.Size = new System.Drawing.Size(108, 21);
            this.chkDescuento.TabIndex = 7;
            this.chkDescuento.Text = "Descuento 20%";
            this.chkDescuento.UseVisualStyleBackColor = true;
            // 
            // lstPedidos
            // 
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.Location = new System.Drawing.Point(22, 204);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(234, 121);
            this.lstPedidos.TabIndex = 6;
            // 
            // lblDatosPedido
            // 
            this.lblDatosPedido.AutoSize = true;
            this.lblDatosPedido.Location = new System.Drawing.Point(19, 188);
            this.lblDatosPedido.Name = "lblDatosPedido";
            this.lblDatosPedido.Size = new System.Drawing.Size(103, 13);
            this.lblDatosPedido.TabIndex = 5;
            this.lblDatosPedido.Text = "Id;Cantidad;Subtotal";
            // 
            // lblSubtotalesPedido
            // 
            this.lblSubtotalesPedido.AutoSize = true;
            this.lblSubtotalesPedido.Location = new System.Drawing.Point(19, 160);
            this.lblSubtotalesPedido.Name = "lblSubtotalesPedido";
            this.lblSubtotalesPedido.Size = new System.Drawing.Size(57, 13);
            this.lblSubtotalesPedido.TabIndex = 4;
            this.lblSubtotalesPedido.Text = "Subtotales";
            // 
            // txtCantidadPedido
            // 
            this.txtCantidadPedido.Location = new System.Drawing.Point(22, 108);
            this.txtCantidadPedido.Name = "txtCantidadPedido";
            this.txtCantidadPedido.Size = new System.Drawing.Size(234, 20);
            this.txtCantidadPedido.TabIndex = 3;
            // 
            // lblCantidadPedido
            // 
            this.lblCantidadPedido.AutoSize = true;
            this.lblCantidadPedido.Location = new System.Drawing.Point(19, 92);
            this.lblCantidadPedido.Name = "lblCantidadPedido";
            this.lblCantidadPedido.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadPedido.TabIndex = 2;
            this.lblCantidadPedido.Text = "Cantidad";
            // 
            // cmbNombrePedido
            // 
            this.cmbNombrePedido.FormattingEnabled = true;
            this.cmbNombrePedido.Location = new System.Drawing.Point(19, 54);
            this.cmbNombrePedido.Name = "cmbNombrePedido";
            this.cmbNombrePedido.Size = new System.Drawing.Size(237, 21);
            this.cmbNombrePedido.TabIndex = 1;
            // 
            // lblNombrePedido
            // 
            this.lblNombrePedido.AutoSize = true;
            this.lblNombrePedido.Location = new System.Drawing.Point(19, 38);
            this.lblNombrePedido.Name = "lblNombrePedido";
            this.lblNombrePedido.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePedido.TabIndex = 0;
            this.lblNombrePedido.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 541);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpProducto);
            this.Controls.Add(this.grpAlta);
            this.Name = "Form1";
            this.Text = "Sistema de gestión de productos";
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtPrecioAlta;
        private System.Windows.Forms.Label lblPrecioAlta;
        private System.Windows.Forms.TextBox txtStockAlta;
        private System.Windows.Forms.Label lblStockAlta;
        private System.Windows.Forms.TextBox txtNombreAlta;
        private System.Windows.Forms.Label lblNombreAlta;
        private System.Windows.Forms.TextBox txtIdAlta;
        private System.Windows.Forms.Label lblIdAlta;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblDatosProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Label lblIdBuscar;
        private System.Windows.Forms.TextBox txtPrecioDatos;
        private System.Windows.Forms.Label lblPrecioDatos;
        private System.Windows.Forms.TextBox txtStockDatos;
        private System.Windows.Forms.Label lblStockDatos;
        private System.Windows.Forms.TextBox txtNombreDatos;
        private System.Windows.Forms.Label lblNombreDatos;
        private System.Windows.Forms.Button btnMostrarPedidos;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.CheckBox chkDescuento;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.Label lblDatosPedido;
        private System.Windows.Forms.Label lblSubtotalesPedido;
        private System.Windows.Forms.TextBox txtCantidadPedido;
        private System.Windows.Forms.Label lblCantidadPedido;
        private System.Windows.Forms.ComboBox cmbNombrePedido;
        private System.Windows.Forms.Label lblNombrePedido;
    }
}

