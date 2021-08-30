using LAB_SEGUNDAPARTE.Entidades;
using LAB_SEGUNDAPARTE.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_SEGUNDAPARTE
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clsPersona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            Console.WriteLine("Escriba los siguientes datos" +
            "\n\n Escribe tu nombre :");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ahora edad: ");
            int edad = Convert.ToInt32 ( Console.ReadLine());
            Console.WriteLine("Ingrese el sexo  : ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Ingresa la altura : ");
            string altura = Console.ReadLine();


            ClsPersona clsPersona1 = new ClsPersona(nombre, edad, sexo); 








        }
    }
}
