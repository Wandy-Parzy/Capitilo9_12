using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Capitulo9_12
{
     class Funciones
     {

      public void factorial()
      {
         int contador = 0, factorial = 1;

         Console.Write("Ingrese un dijito: ");
         int num = Int32.Parse(Console.ReadLine());
         for (int i = 1; i <= num; i++)
         {
            contador = contador + 1; 
            factorial = factorial + contador;
         }
         Console.WriteLine($"El factorial es {factorial}");
      }

        public int lado;
        public  void Poligono(int lado)
        {
            this.lado =  lado;
        }

        public void calcular()
        {
            Console.WriteLine($"\n Lado: ");
            int lado = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"\n Area: {lado+lado+lado+lado} \n Perimetro: {lado*lado}");
        }

        public override string ToString()
        {
            string mostrar = "";
            mostrar += "lado" + lado.ToString();

            return mostrar;
        }
    }   
}

