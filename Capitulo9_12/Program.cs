using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo9_12{
class Program{
    static void Main(string[] args){
               
            int operador = 0;

            Funciones n = new Funciones();
        do{

            Console.Write("\n -----------MENU-----------\n\n");
            Console.Write("\n ---Selecciona una opcion:n ");
            Console.Write("\n 1) Capitulo # 10 Poligono ");
            Console.Write("\n 2) Capitulo # 12 factorial ");
            Console.Write("\n 3) Salir\n\n ");
                
            operador = Int16.Parse(Console.ReadLine());
            Console.Clear();

            switch(operador)
            {

                case 1:
                    Console.Clear();
                    n.calcular();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 2:
                        Console.Clear();
                        n.factorial();
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 3: 
                        Console.Clear();
                        break;
                    }

               }while(operador != 3);
          }
      
        }
}