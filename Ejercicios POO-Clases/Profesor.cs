using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
 /*2- Crea una clase “Profesor” con propiedades para “nombre” “apellido” “edad”
 y “materia” agrega metodos para mostrar los detalles del estudiante.
 utiliza la auto-implementacion de atributos y propiedades de clases.*/
     
    public class Profesor
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string materia;
        //atributos de las clases
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Materia { get; set; }

        public Profesor(string nombre, string apellido, int edad, string materia)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Materia = materia;
        }
        public void DetallesProfesor()
        {
            Console.WriteLine();
            Console.WriteLine("Detalles del Profesor");
            Console.WriteLine();
            Console.WriteLine($" Nombre y Apellido : {Nombre} {Apellido}");
            Console.WriteLine($" Edad : {Edad}");
            Console.WriteLine($" Materia : {Materia}");
            Console.WriteLine();
        }
    }
}
