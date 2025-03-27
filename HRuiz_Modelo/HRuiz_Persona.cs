using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRuiz_Personas.HRuiz_Modelo
{
    internal class HRuiz_Persona
    {
        public String HRuiz_DNI;
        public String HRuiz_nombre;
        public String HRuiz_apellidos;
        public String HRuiz_direccion;
        public String HRuiz_ciudad;

        public HRuiz_Persona(string hRuiz_DNI, string hRuiz_nombre, string hRuiz_apellidos, string hRuiz_direccion, string hRuiz_ciudad)
        {
            HRuiz_DNI1 = hRuiz_DNI;
            HRuiz_nombre1 = hRuiz_nombre;
            HRuiz_apellidos1 = hRuiz_apellidos;
            HRuiz_direccion1 = hRuiz_direccion;
            HRuiz_ciudad1 = hRuiz_ciudad;
        }

        public HRuiz_Persona(string hRuiz_nombre, string hRuiz_apellidos, string hRuiz_direccion, string hRuiz_ciudad)
        {
            HRuiz_nombre1 = hRuiz_nombre;
            HRuiz_apellidos1 = hRuiz_apellidos;
            HRuiz_direccion1 = hRuiz_direccion;
            HRuiz_ciudad1 = hRuiz_ciudad;
        }


        public string HRuiz_DNI1 { get => HRuiz_DNI; set => HRuiz_DNI = value; }
        public string HRuiz_nombre1 { get => HRuiz_nombre; set => HRuiz_nombre = value; }
        public string HRuiz_apellidos1 { get => HRuiz_apellidos; set => HRuiz_apellidos = value; }
        public string HRuiz_direccion1 { get => HRuiz_direccion; set => HRuiz_direccion = value; }
        public string HRuiz_ciudad1 { get => HRuiz_ciudad; set => HRuiz_ciudad = value; }

    }
}
