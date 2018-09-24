namespace Presentacion
{
    partial class frmPrincipal
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
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentas.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnVentas.Location = new System.Drawing.Point(95, 33);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(650, 300);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompras.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCompras.Location = new System.Drawing.Point(813, 33);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(650, 300);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductos.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnProductos.Location = new System.Drawing.Point(95, 344);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(650, 300);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngredientes.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnIngredientes.Location = new System.Drawing.Point(813, 344);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(650, 300);
            this.btnIngredientes.TabIndex = 4;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClientes.Location = new System.Drawing.Point(813, 653);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(650, 300);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProveedor.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnProveedor.Location = new System.Drawing.Point(95, 653);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(650, 300);
            this.btnProveedor.TabIndex = 6;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 973);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnVentas);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedor;
    }
}