namespace Presentacion
{
    partial class frmCompras
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
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtboxIdCompra = new System.Windows.Forms.TextBox();
            this.lblIdCompra = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBoxDescripcion.Location = new System.Drawing.Point(403, 155);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(763, 47);
            this.txtBoxDescripcion.TabIndex = 26;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(195, 163);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(179, 39);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtboxIdCompra
            // 
            this.txtboxIdCompra.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxIdCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxIdCompra.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtboxIdCompra.Location = new System.Drawing.Point(403, 78);
            this.txtboxIdCompra.Name = "txtboxIdCompra";
            this.txtboxIdCompra.Size = new System.Drawing.Size(763, 47);
            this.txtboxIdCompra.TabIndex = 24;
            // 
            // lblIdCompra
            // 
            this.lblIdCompra.AutoSize = true;
            this.lblIdCompra.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIdCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdCompra.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblIdCompra.Location = new System.Drawing.Point(195, 80);
            this.lblIdCompra.Name = "lblIdCompra";
            this.lblIdCompra.Size = new System.Drawing.Size(163, 39);
            this.lblIdCompra.TabIndex = 23;
            this.lblIdCompra.Text = "ID Compra:";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCantidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBoxCantidad.Location = new System.Drawing.Point(403, 308);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(763, 47);
            this.txtBoxCantidad.TabIndex = 30;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCantidad.Location = new System.Drawing.Point(195, 316);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(142, 39);
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrecio.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBoxPrecio.Location = new System.Drawing.Point(403, 231);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(763, 47);
            this.txtBoxPrecio.TabIndex = 28;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(195, 233);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(108, 39);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio:";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1531, 679);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtboxIdCompra);
            this.Controls.Add(this.lblIdCompra);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtboxIdCompra;
        private System.Windows.Forms.Label lblIdCompra;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}