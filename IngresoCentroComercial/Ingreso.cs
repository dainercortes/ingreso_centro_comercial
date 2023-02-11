using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoCentroComercial
{
    internal class Ingreso
    {
        //Atributo de la clase
        private int dia;
        private int digito;

        //Metodo contructor
        public Ingreso()
        {
            dia = 0;
            digito = 0;
        }

        //Metodos de la clase
        public void setDia(int d)
        {
            d = dia;
        }
        public void setDigito(int g)
        {
            g = digito;
        }
        public int getDia()
        {
            return dia;
        }
        public int getDigito()
        {
            return digito;
        }
        //Metodo para ingresar los datos solicitados
        public void IngresarDatos()
        {
            Console.WriteLine("\n Ingrese los datos para saber si puede ingresar al centro comercial");

            Console.Write("\n Día actual: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("\n Ultimo dígito de la cédula: ");
            digito = int.Parse(Console.ReadLine());
        }
        public void VerificarIngreso()
        {
            //Calcula si el dia y el digito son pares
            if (dia % 2 == 0 && digito % 2 == 0)
            {
                Console.WriteLine("\n Puede Ingresar al centro comercial");
            }
            //Calcula si el dia y el digito son impares
            else if (dia % 2 != 0 && digito % 2 != 0)
            {
                Console.WriteLine("\n Puede ingresar al centro comercial");
            }
            //Si las condiciones no se cumplen muestra que no puede ingresar 
            else
            {
                Console.WriteLine("\n No puede ingresar al centro comercial");
            }
        }
    }
}
