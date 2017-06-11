namespace ape_busquedaBinaria
{
    partial class frmPrincipal
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTamaño = new System.Windows.Forms.Button();
            this.txtTamañoVector = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnLimite = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(107, 148);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(86, 105);
            this.txtResultado.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(161, 279);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTamaño
            // 
            this.btnTamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamaño.Location = new System.Drawing.Point(40, 62);
            this.btnTamaño.Name = "btnTamaño";
            this.btnTamaño.Size = new System.Drawing.Size(100, 37);
            this.btnTamaño.TabIndex = 2;
            this.btnTamaño.Text = "Tamaño del vector";
            this.btnTamaño.UseVisualStyleBackColor = true;
            this.btnTamaño.Click += new System.EventHandler(this.btnTamaño_Click);
            // 
            // txtTamañoVector
            // 
            this.txtTamañoVector.Location = new System.Drawing.Point(40, 36);
            this.txtTamañoVector.Name = "txtTamañoVector";
            this.txtTamañoVector.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoVector.TabIndex = 3;
            this.txtTamañoVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(161, 36);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 5;
            this.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimite
            // 
            this.btnLimite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimite.Location = new System.Drawing.Point(161, 62);
            this.btnLimite.Name = "btnLimite";
            this.btnLimite.Size = new System.Drawing.Size(100, 37);
            this.btnLimite.TabIndex = 4;
            this.btnLimite.Text = "Límite del vector";
            this.btnLimite.UseVisualStyleBackColor = true;
            this.btnLimite.Click += new System.EventHandler(this.btnLimite_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(40, 281);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(98, 119);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(104, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 339);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.btnLimite);
            this.Controls.Add(this.txtTamañoVector);
            this.Controls.Add(this.btnTamaño);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtResultado);
            this.Name = "frmPrincipal";
            this.Text = "Búsqueda binaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTamaño;
        private System.Windows.Forms.TextBox txtTamañoVector;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnLimite;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnMostrar;
    }
}

