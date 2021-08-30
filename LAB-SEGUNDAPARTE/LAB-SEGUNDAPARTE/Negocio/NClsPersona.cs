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
        ClsPersona per = new ClsPersona();
        public string calcularIMC()
        {
            

            double pro = per.Peso / Math.Pow(per.Altura, 2);


            if (pro < 20)
            {
                return "peso es ideal";
            }
            if (pro > 25)
            {
                return "tiene sobre peso";
            }
            return "";   
            
            
        }   
        public string esMayorDeEdad()
        {
            if (per.Edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
                return "No es mayor de edad";
           
        }
    }
}
