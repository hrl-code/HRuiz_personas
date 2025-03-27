using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRuiz_Personas.Vistas
{
    public partial class HRuiz_Buscar : Form
    {
        public HRuiz_Buscar()
        {
            InitializeComponent();
        }

        private void HRuiz_botonBuscar_Click(object sender, EventArgs e)
        {
            HRcampoCiudad.Text = "";
            HRcampoDireccion.Text = "";
            HRcampoNombre.Text = "";
            HRcampoApellidos.Text = "";
            HRuiz_rescatarDatos();
        }
    }
}
