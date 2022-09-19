using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo9_12{
class Program{
    static void Main(string[] args){
               
            int operador = 0, lado = 20;

            Funciones n = new Funciones();
            Inventario n3 = new Inventario();
            Poligono n4 = new Poligono(lado);     

        do{

            Console.Write("\n -----------MENU-----------\n\n");
            Console.Write("\n ---Selecciona una opcion:n ");
            Console.Write("\n 1) Capitulo # 9 ");
            Console.Write("\n 2) Capitulo # 10 ");
            Console.Write("\n 3) Capitulo # 12");
            Console.Write("\n 4) Capitulo # 12");
            Console.Write("\n 5) Salir\n\n ");
                
            operador = Int16.Parse(Console.ReadLine());
            Console.Clear();

            switch(operador)
            {
                case 1:
                    Console.Clear();
                    n3.visualizar();
                    Console.ReadKey(); 
                    Console.Clear();
                break;

                case 2:
                    Console.Clear();
                    n4.calcular();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 3:
                        Console.Clear();
                        n.factorial();
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 4:
                        Console.Clear();
                        n.mostrardata();
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 5: 
                        Console.Clear();
                        break;
                    }

               }while(operador != 5);
          }
      
        }
}