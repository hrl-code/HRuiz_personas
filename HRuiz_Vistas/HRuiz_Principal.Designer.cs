namespace HRuiz_Personas
{
    partial class Principal
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
            this.HRuiz_botonRegistrar = new System.Windows.Forms.Button();
            this.HRuiz_botonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HRuiz_botonRegistrar
            // 
            this.HRuiz_botonRegistrar.BackColor = System.Drawing.Color.Black;
            this.HRuiz_botonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRuiz_botonRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HRuiz_botonRegistrar.Location = new System.Drawing.Point(132, 168);
            this.HRuiz_botonRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HRuiz_botonRegistrar.Name = "HRuiz_botonRegistrar";
            this.HRuiz_botonRegistrar.Size = new System.Drawing.Size(170, 100);
            this.HRuiz_botonRegistrar.TabIndex = 0;
            this.HRuiz_botonRegistrar.Text = "Registrar";
            this.HRuiz_botonRegistrar.UseVisualStyleBackColor = false;
            this.HRuiz_botonRegistrar.Click += new System.EventHandler(this.HRuiz_botonHRuiz_Registrar_Click);
            // 
            // HRuiz_botonBuscar
            // 
            this.HRuiz_botonBuscar.BackColor = System.Drawing.Color.Black;
            this.HRuiz_botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRuiz_botonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HRuiz_botonBuscar.Location = new System.Drawing.Point(408, 168);
            this.HRuiz_botonBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HRuiz_botonBuscar.Name = "HRuiz_botonBuscar";
            this.HRuiz_botonBuscar.Size = new System.Drawing.Size(170, 100);
            this.HRuiz_botonBuscar.TabIndex = 1;
            this.HRuiz_botonBuscar.Text = "Buscar persona";
            this.HRuiz_botonBuscar.UseVisualStyleBackColor = false;
            this.HRuiz_botonBuscar.Click += new System.EventHandler(this.HRuiz_botonBuscar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(748, 458);
            this.Controls.Add(this.HRuiz_botonBuscar);
            this.Controls.Add(this.HRuiz_botonRegistrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HRuiz_botonRegistrar;
        private System.Windows.Forms.Button HRuiz_botonBuscar;
    }
}

