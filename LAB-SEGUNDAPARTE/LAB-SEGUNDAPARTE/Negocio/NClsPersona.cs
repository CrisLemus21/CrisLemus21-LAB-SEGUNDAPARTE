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
        
        public string calcularIMC()
        {
            ClsPersona per= new ClsPersona();

            double pro;
            pro = (per.Peso / Math.Pow(per.Altura, 2));

            if (pro <= 20)
            {
                return"peso ideal";
            }
           else

            
            return "tiene sobre peso";
        }
        public string esMayorDeEdad()
        {
            ClsPersona cls = new ClsPersona();
            if (cls.Edad >= 18)
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
