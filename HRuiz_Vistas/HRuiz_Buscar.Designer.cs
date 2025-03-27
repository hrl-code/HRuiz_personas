using System.Windows.Forms;
using HRuiz_Personas.HRuiz_Modelo;
using HRuiz_Personas.HRuiz_Conexion;

namespace HRuiz_Personas.Vistas
{
    partial class HRuiz_Buscar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HRcampoCiudad = new System.Windows.Forms.TextBox();
            this.HRcampoDireccion = new System.Windows.Forms.TextBox();
            this.HRcampoApellidos = new System.Windows.Forms.TextBox();
            this.HRcampoNombre = new System.Windows.Forms.TextBox();
            this.HRcampoDNI = new System.Windows.Forms.TextBox();
            this.HRuiz_botonBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HRcampoCiudad);
            this.groupBox1.Controls.Add(this.HRcampoDireccion);
            this.groupBox1.Controls.Add(this.HRcampoApellidos);
            this.groupBox1.Controls.Add(this.HRcampoNombre);
            this.groupBox1.Controls.Add(this.HRcampoDNI);
            this.groupBox1.Controls.Add(this.HRuiz_botonBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(194, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(439, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // HRcampoCiudad
            // 
            this.HRcampoCiudad.Location = new System.Drawing.Point(157, 301);
            this.HRcampoCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoCiudad.Name = "HRcampoCiudad";
            this.HRcampoCiudad.Size = new System.Drawing.Size(157, 20);
            this.HRcampoCiudad.TabIndex = 10;
            // 
            // HRcampoDireccion
            // 
            this.HRcampoDireccion.Location = new System.Drawing.Point(157, 243);
            this.HRcampoDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoDireccion.Name = "HRcampoDireccion";
            this.HRcampoDireccion.Size = new System.Drawing.Size(157, 20);
            this.HRcampoDireccion.TabIndex = 9;
            // 
            // HRcampoApellidos
            // 
            this.HRcampoApellidos.Location = new System.Drawing.Point(157, 186);
            this.HRcampoApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoApellidos.Name = "HRcampoApellidos";
            this.HRcampoApellidos.Size = new System.Drawing.Size(157, 20);
            this.HRcampoApellidos.TabIndex = 8;
            // 
            // HRcampoNombre
            // 
            this.HRcampoNombre.Location = new System.Drawing.Point(157, 124);
            this.HRcampoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoNombre.Name = "HRcampoNombre";
            this.HRcampoNombre.Size = new System.Drawing.Size(157, 20);
            this.HRcampoNombre.TabIndex = 7;
            // 
            // HRcampoDNI
            // 
            this.HRcampoDNI.Location = new System.Drawing.Point(157, 56);
            this.HRcampoDNI.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoDNI.Name = "HRcampoDNI";
            this.HRcampoDNI.Size = new System.Drawing.Size(157, 20);
            this.HRcampoDNI.TabIndex = 6;
            // 
            // HRuiz_botonBuscar
            // 
            this.HRuiz_botonBuscar.BackColor = System.Drawing.Color.Black;
            this.HRuiz_botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRuiz_botonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HRuiz_botonBuscar.Location = new System.Drawing.Point(336, 48);
            this.HRuiz_botonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.HRuiz_botonBuscar.Name = "HRuiz_botonBuscar";
            this.HRuiz_botonBuscar.Size = new System.Drawing.Size(98, 28);
            this.HRuiz_botonBuscar.TabIndex = 5;
            this.HRuiz_botonBuscar.Text = "Buscar";
            this.HRuiz_botonBuscar.UseVisualStyleBackColor = false;
            this.HRuiz_botonBuscar.Click += new System.EventHandler(this.HRuiz_botonBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // HRuiz_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HRuiz_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRuiz_Buscar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox HRcampoCiudad;
        private System.Windows.Forms.TextBox HRcampoDireccion;
        private System.Windows.Forms.TextBox HRcampoApellidos;
        private System.Windows.Forms.TextBox HRcampoNombre;
        private System.Windows.Forms.TextBox HRcampoDNI;
        private System.Windows.Forms.Button HRuiz_botonBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public void HRuiz_rescatarDatos()
        {
            string HRuiz_dniInput = HRcampoDNI.Text.ToUpper();

            if (!HRuiz_validarDNI(HRuiz_dniInput))
            {
                MessageBox.Show("DNI no válido");
                return;
            }

            string HRuiz_encryptedDni = new HRuiz_Encriptar().HRuiz_EncriptarTexto(HRuiz_dniInput);

            HRuiz_Persona persona = HRuiz_Conexion.HRuiz_Conexion.HRuiz_RescatarDatos(HRuiz_encryptedDni);


            if (persona != null)
            {
                HRcampoNombre.Text = persona.HRuiz_nombre;
                HRcampoApellidos.Text = persona.HRuiz_apellidos;
                HRcampoDireccion.Text = persona.HRuiz_direccion;
                HRcampoCiudad.Text = persona.HRuiz_ciudad;
            }
            else
            {
                MessageBox.Show("No se ha encontrado el DNI");
            }
        }

        public static bool HRuiz_validarDNI(string dni)
        {
            if (dni.Length != 9)
            {
                return false;
            }

            string numeros = dni.Substring(0, 8);
            if (!System.Text.RegularExpressions.Regex.IsMatch(numeros, @"^\d{8}$"))
            {
                return false;
            }

            char letra = dni[8];
            if (!char.IsLetter(letra))
            {
                return false;
            }

            if (!int.TryParse(numeros, out int numero))
            {
                return false;
            }

            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            int resto = numero % 23;
            return char.ToUpper(letra) == letras[resto];
        }


    }
}