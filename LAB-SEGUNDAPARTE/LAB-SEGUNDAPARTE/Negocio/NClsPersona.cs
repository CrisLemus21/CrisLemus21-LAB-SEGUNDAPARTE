using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_SEGUNDAPARTE.Entidades;

namespace LAB_SEGUNDAPARTE.Negocio
{
    class NClsPersona

    {
        
        public string calcularIMC(ClsPersona persona)
        {
            double pro;
            pro = (persona.Peso / Math.Pow(persona.Altura, 2));

            if (pro <= 20)
            {
                return"Peso ideal";
            }
            else
            {
                return "Tienen sobre peso";
            }
        }
        public string esMayorDeEdad(ClsPersona persona)
        {
            if (persona.Edad >= 18)
            {
                return "Es mayor de Edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }

    }   
}
