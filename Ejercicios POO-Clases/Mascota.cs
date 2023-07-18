using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
    /*6- Crea una clase “Mascota” utiliza propiedades para 
      “nombre” “edad” “raza” agrega metodos para alimentar ,
      jugar y mostrar los detalles de la mascota.*/

    public class Mascota
    {
        //Propiedades y atributos
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }

        //Constructor
        public Mascota()
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Raza = Raza;
        }

        //Metodo alimentar
        public void Alimentar(string comida)
        {
            Console.WriteLine();
            Console.WriteLine($"Mi perrito {Nombre} esta comiendo {comida} mmumumum");
            Console.WriteLine();
        }
        //Metodo jugar
        public void Jugar(string juguete)
        {
            Console.WriteLine();
            Console.WriteLine($" Mi perrito {Nombre} esta jugando con la {juguete}");
            Console.WriteLine();
        }
     //Metodo detalles de la mascota
        public void DetallesMascota()
        {
            Console.WriteLine();
            Console.WriteLine(" Detalle de la Mascota");
            Console.WriteLine();
            Console.WriteLine($"   Nombre : {Nombre}");
            Console.WriteLine($"   Raza : {Raza}");
            Console.WriteLine($"   Edad : {Edad}");
            Console.WriteLine();
        }

    }
}
