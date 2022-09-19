using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



// Funciones de ejecucion del programa

namespace Capitulo9_12
{
     class Funciones
     {

      public void factorial()
      {
         int count = 0, factorial = 1;
         Console.Write("Ingrese un dijito: ");
         int dijito = Int32.Parse(Console.ReadLine());
         for (int i = 1; i <= dijito; i++)
         {
            count = count + 1; 
            factorial = factorial + count;
         }
         Console.WriteLine($"El factorial de {dijito} es {factorial}");
      }

        
        public struct tienda
        {
            public double Precio;
            public string NombreProducto = string.Empty;

             public tienda(double Precio, string NombreProducto)
            {
                this.Precio = Precio;
                this.NombreProducto = NombreProducto;
            }

        }
        public struct MascotaDueño
        {
            public string NombreDueño = string.Empty;
            public string NombreMascota = string.Empty;

            public string Edades = string.Empty;

            public string Direccion = string.Empty;

            tienda productos = new tienda();


            public MascotaDueño(){}

            public void setNombre(string NombreDueño)
            {
                this.NombreDueño = NombreDueño;
            }

            public string getNombre(){
                return NombreDueño;
            }

            public void setNombreMascota(string NombreMascota)
            {
                this.NombreMascota = NombreMascota;
            }

            public string getNombreMascota(){
                return NombreMascota;
            }

            public void setEdades(string Edades)
            {
                this.Edades = Edades;
            }

            public string getEdades(){
                return Edades;
            }

            public void setDireccion(string Direccion)
            {
                this.Direccion = Direccion;
            }

            public string getDireccion()
            {
                return Direccion;
            }

            public void setPrecio(double Precio)
            {
                this.productos.Precio = Precio;
            }

            public double getPrecio()
            {
                return productos.Precio;
            }

            public void setNombreProducto(string NombreProducto)
            {
                this.productos.NombreProducto = NombreProducto;
            }

            public string getNombreProducto()
            {
                return productos.NombreProducto;
            }
        }
        public void mostrardata()
        { 
            MascotaDueño datos = new MascotaDueño();            

            datos.setNombre("Angel");
            datos.setNombreMascota("Roky");
            datos.setEdades("25 y 7 años");
            datos.setDireccion("Los Arroyo, San Francisco");
            datos.setPrecio(1000);
            datos.setNombreProducto("Pastas");

            Console.WriteLine($"\n<><><> Datos <><><> \n\n(-) Nombre del Dueño: {datos.getNombre()} \n(-) Nombre de la mascota: {datos.getNombreMascota()} \n(-) Edad dueño_mascota: {datos.getEdades()} \n(-) Direccion: {datos.getDireccion()} \n(-) Precio: {datos.getPrecio()} \n(-) Nombre del producto: {datos.getNombreProducto()}");
            
            Estrellas estrellas = Estrellas.Enana_amarilla;

            Console.WriteLine("(-) Estrella: " + estrellas + "\n");
            
        }

        enum Estrellas {Estrella_de_neutrones, Enana_roja, Enana_naranja, Enana_amarilla, 
        Enana_blanca, Enana_marrón, Enana_azul, Enana_negra, Subenana, Subgigante, Gigante, 
        Gigante_luminosa, Supergigante, Supergigante_luminosa, Hipergigante}
    }

    public class Poligono
    {

        public int lado;
        public Poligono(int lado)
        {
            this.lado =  lado;
        }

        public void calcular()
        {
            Console.WriteLine($"\n Area: {lado+lado+lado+lado} \n Perimetro: {lado*lado}");
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje += "lado" + lado.ToString();

            return mensaje;
        }

   
    }

    public  class Estudiantes
    {

        private string nombre = "Angel";
        private string apellido = "Luis";
        private int edad = 21;
        private string direccion = "Calle los Arroyos";

        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getnombre()
        {
            return nombre;
        }

        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getapellido()
        {
            return apellido;
        }

        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public int getedad()
        {
            return edad;
        }

        public void setdireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getdireccion()
        {
            return direccion;
        }
         public void Mostrar()
        {
            Console.WriteLine("Nombre: " + getnombre());
            Console.WriteLine( "Apellido: " +getapellido());
            Console.WriteLine("Edad: " + getedad());
            Console.WriteLine("Direccion: " + getdireccion());
        }
    } 

    class Inventario
    {
        private string referencia;
        private int cantidad;
        public void setReferencia(string a){referencia = a;}  
        public void setCantidad(int e){cantidad = e;}

        public string getReferencia(){return referencia;}
        public int getCantidad(){return cantidad;}    
        public void visualizar()
        {
            string referencia;
            int cantidad;
            Inventario a1 = new Inventario();
            Console.WriteLine("Ingrese una refencia de productos: ");
            referencia = Console.ReadLine();
            a1.setReferencia(referencia);
            Console.WriteLine("Ingrese cantidad: ");
            cantidad = Int32.Parse(Console.ReadLine());
            a1.setCantidad(cantidad);

            Console.WriteLine(getReferencia() + getCantidad());
            
            Estudiantes e = new Estudiantes();
             e.Mostrar();
        }
    }
}


