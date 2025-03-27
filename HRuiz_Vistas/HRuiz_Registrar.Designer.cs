using System.Drawing;
using System.Windows.Forms;
using HRuiz_Personas.HRuiz_Modelo;
using HRuiz_Personas.HRuiz_Conexion;


namespace HRuiz_Personas.Vistas
{
    partial class HRuiz_Registrar
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
            this.HRcomboCiudad = new System.Windows.Forms.ComboBox();
            this.HRcampoDireccion = new System.Windows.Forms.TextBox();
            this.HRcampoApellidos = new System.Windows.Forms.TextBox();
            this.HRcampoNombre = new System.Windows.Forms.TextBox();
            this.HRcampoDNI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.HRcomboCiudad);
            this.groupBox1.Controls.Add(this.HRcampoDireccion);
            this.groupBox1.Controls.Add(this.HRcampoApellidos);
            this.groupBox1.Controls.Add(this.HRcampoNombre);
            this.groupBox1.Controls.Add(this.HRcampoDNI);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(195, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(392, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar";
            // 
            // HRcomboCiudad
            // 
            this.HRcomboCiudad.FormattingEnabled = true;
            this.HRcomboCiudad.Items.AddRange(new object[] {
            "Seleccione",
            "Madrid",
            "Valencia ",
            "Zaragoza",
            "Segovia",
            "Huesca"});
            this.HRcomboCiudad.Location = new System.Drawing.Point(192, 253);
            this.HRcomboCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.HRcomboCiudad.Name = "HRcomboCiudad";
            this.HRcomboCiudad.Size = new System.Drawing.Size(157, 21);
            this.HRcomboCiudad.TabIndex = 10;
            this.HRcomboCiudad.Tag = "Ciudad";
            // 
            // HRcampoDireccion
            // 
            this.HRcampoDireccion.Location = new System.Drawing.Point(192, 203);
            this.HRcampoDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoDireccion.Name = "HRcampoDireccion";
            this.HRcampoDireccion.Size = new System.Drawing.Size(157, 20);
            this.HRcampoDireccion.TabIndex = 9;
            this.HRcampoDireccion.Tag = "Direccion";
            // 
            // HRcampoApellidos
            // 
            this.HRcampoApellidos.Location = new System.Drawing.Point(192, 157);
            this.HRcampoApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoApellidos.Name = "HRcampoApellidos";
            this.HRcampoApellidos.Size = new System.Drawing.Size(157, 20);
            this.HRcampoApellidos.TabIndex = 8;
            this.HRcampoApellidos.Tag = "Apellidos";
            // 
            // HRcampoNombre
            // 
            this.HRcampoNombre.Location = new System.Drawing.Point(192, 107);
            this.HRcampoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoNombre.Name = "HRcampoNombre";
            this.HRcampoNombre.Size = new System.Drawing.Size(157, 20);
            this.HRcampoNombre.TabIndex = 7;
            this.HRcampoNombre.Tag = "Nombre";
            // 
            // HRcampoDNI
            // 
            this.HRcampoDNI.Location = new System.Drawing.Point(192, 58);
            this.HRcampoDNI.Margin = new System.Windows.Forms.Padding(2);
            this.HRcampoDNI.Name = "HRcampoDNI";
            this.HRcampoDNI.Size = new System.Drawing.Size(157, 20);
            this.HRcampoDNI.TabIndex = 6;
            this.HRcampoDNI.Tag = "DNI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(138, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(33, 253);
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
            this.label4.Location = new System.Drawing.Point(33, 200);
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
            this.label3.Location = new System.Drawing.Point(33, 154);
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
            this.label2.Location = new System.Drawing.Point(33, 104);
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
            // HRuiz_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(801, 471);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HRuiz_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRuiz_Registrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HRcomboCiudad;
        private System.Windows.Forms.TextBox HRcampoDireccion;
        private System.Windows.Forms.TextBox HRcampoApellidos;
        private System.Windows.Forms.TextBox HRcampoNombre;
        private System.Windows.Forms.TextBox HRcampoDNI;

        string HRuiz_dni;
        string HRuiz_nom;
        string HRuiz_ape;
        string HRuiz_dir;
        string HRuiz_ciu;

        public void HRuiz_registro()
        {
            // Validación de datos
            if (HRuiz_campoVacio(HRcampoDNI))
            {
                HRuiz_alertaVacio(HRcampoDNI);
            }
            else if (!HRuiz_validarDNI(HRcampoDNI.Text))
            {
                MessageBox.Show("DNI no válido");
            }
            else if (HRuiz_campoVacio(HRcampoNombre))
            {
                HRuiz_alertaVacio(HRcampoNombre);
            }
            else if (HRuiz_campoVacio(HRcampoApellidos))
            {
                HRuiz_alertaVacio(HRcampoApellidos);
            }
            else if (HRuiz_campoVacio(HRcampoDireccion))
            {
                HRuiz_alertaVacio(HRcampoDireccion);
            }
            else if (HRcomboCiudad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una ciudad");
            }
            else if (!HRuiz_DNIexiste())
            {
                MessageBox.Show("El DNI ya existe");
            }
            else
            {

                HRuiz_Encriptar encriptar = new HRuiz_Encriptar();
                HRuiz_dni = encriptar.HRuiz_EncriptarTexto(HRcampoDNI.Text.ToUpper());
                HRuiz_nom = encriptar.HRuiz_EncriptarTexto(HRcampoNombre.Text);
                HRuiz_ape = encriptar.HRuiz_EncriptarTexto(HRcampoApellidos.Text);
                HRuiz_dir = encriptar.HRuiz_EncriptarTexto(HRcampoDireccion.Text);
                HRuiz_ciu = encriptar.HRuiz_EncriptarTexto(HRcomboCiudad.SelectedItem.ToString());

                HRuiz_Modelo.HRuiz_Persona pr = new HRuiz_Modelo.HRuiz_Persona(HRuiz_dni, HRuiz_nom, HRuiz_ape, HRuiz_dir, HRuiz_ciu);


                if (HRuiz_Conexion.HRuiz_Conexion.HRuiz_RegistrarPersonas(pr))
                {
                    MessageBox.Show("Usuario registrado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error en el registro");
                }
                ;

                // Reinicio de los controles
                HRcampoApellidos.Text = "";
                HRcampoDNI.Text = "";
                HRcampoDireccion.Text = "";
                HRcampoNombre.Text = "";
                HRcomboCiudad.SelectedIndex = 0;
            }
        }

        public static bool HRuiz_campoVacio(TextBox campo)
        {
            return string.IsNullOrEmpty(campo.Text);
        }

        public static void HRuiz_alertaVacio(TextBox campo)
        {
            MessageBox.Show("El campo " + campo.Tag + " no puede estar vacío");
            campo.BackColor = Color.Red;
            campo.MouseClick += (sender, e) =>
            {
                campo.BackColor = Color.White;
            };
        }

        public static bool HRuiz_validarDNI(string dni)
        {
            if (dni.Length != 9)
            {
                return false;
            }

            string numeros = dni.Substring(0, 8);
            // Verifica que 'numeros' contenga exactamente 8 dígitos
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

        public bool HRuiz_DNIexiste()
        {
            if (HRuiz_Conexion.HRuiz_Conexion.HRuiz_existeDNI(HRcampoDNI.Text))
            {
                return false;
            }
            return true;
        }

    }
}