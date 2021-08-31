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

            Console.WriteLine("Escriba su nombre");
            String nombre = (Console.ReadLine());

            Console.WriteLine("Escriba su genero H o M");
            String sexo = (Console.ReadLine());

            Console.WriteLine("Escriba su edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su peso");
            Double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba su altura");
            Double altura = Convert.ToDouble(Console.ReadLine());

            ClsPersona persona = new ClsPersona(nombre, edad, sexo, peso, altura);

            ClsPersona persona1 = new ClsPersona(nombre, edad, sexo);

            Console.WriteLine(nclspersona.calcularIMC(persona));

            Console.WriteLine(nclspersona.esMayorDeEdad(persona1));

            Console.WriteLine(persona.ToString());
            Console.ReadLine();
        }
    }
}
