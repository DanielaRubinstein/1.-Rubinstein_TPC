namespace Presentacion
{
    partial class frmUsuarios
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
            this.btnIngresarUser = new System.Windows.Forms.Button();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.txtbContrasenia = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresarUser
            // 
            this.btnIngresarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresarUser.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnIngresarUser.Location = new System.Drawing.Point(303, 220);
            this.btnIngresarUser.Name = "btnIngresarUser";
            this.btnIngresarUser.Size = new System.Drawing.Size(176, 48);
            this.btnIngresarUser.TabIndex = 0;
            this.btnIngresarUser.Text = "Ingresar";
            this.btnIngresarUser.UseVisualStyleBackColor = true;
            this.btnIngresarUser.Click += new System.EventHandler(this.btnIngresarUser_Click);
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtbUsuario.Location = new System.Drawing.Point(210, 44);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(500, 47);
            this.txtbUsuario.TabIndex = 2;
            this.txtbUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbContrasenia
            // 
            this.txtbContrasenia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtbContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbContrasenia.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtbContrasenia.Location = new System.Drawing.Point(210, 127);
            this.txtbContrasenia.Name = "txtbContrasenia";
            this.txtbContrasenia.Size = new System.Drawing.Size(500, 47);
            this.txtbContrasenia.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(29, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(127, 39);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblContrasenia.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblContrasenia.Location = new System.Drawing.Point(29, 130);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(174, 39);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(776, 298);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtbContrasenia);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.btnIngresarUser);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarUser;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.TextBox txtbContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
    }
}