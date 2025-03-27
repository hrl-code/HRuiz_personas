using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRuiz_Personas.Vistas;

namespace HRuiz_Personas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void HRuiz_botonHRuiz_Registrar_Click(object sender, EventArgs e)
        {
            HRuiz_Registrar HRuiz_Registrar = new HRuiz_Registrar();
            HRuiz_Registrar.ShowDialog();
        }

        private void HRuiz_botonBuscar_Click(object sender, EventArgs e)
        {
            HRuiz_Buscar HRuiz_Buscar = new HRuiz_Buscar();
            HRuiz_Buscar.ShowDialog();
        }
    }
}
