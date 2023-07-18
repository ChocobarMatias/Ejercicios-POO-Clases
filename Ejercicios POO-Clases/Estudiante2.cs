using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
    /*7- Crea una clase “Estudiante” con propiedades para 
     “nombre” “edad” “legajo” “notas” agrega metodos para 
     mostrar los detalles del estudiante y otro metodo para 
     calcular el promedio de notas del alumno .*/
     
    public class Estudiante2
    {
        double contador;
        //Propiedades y ATRIBUTOS
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Legajo { get; set; }
        public int Notas { get; set; }
        //constructor
        public Estudiante2()
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Legajo = Legajo;
            this.Notas = Notas;

        }
        //Metodo detalles del Estudiante
        public void DetalleEstudiante2(int num)
        {
            Console.WriteLine();
            Console.WriteLine(" Detalles del Estudiante");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine($"     Nombre : {Nombre}");
            Console.WriteLine($"     Edad : {Edad}");
            Console.WriteLine($"     Legajo : {Legajo}");
            Random aleatorio = new Random();
            for (int i = 0; i < num; i++)
            {
                int numero = aleatorio.Next(1, 10);
                Console.WriteLine($"     Nota {i + 1}: {numero}");
                    Notas += numero;
                    contador++;
            }
        }
            //Metodo Calculo del promedio de las notas del Alumno
            public void PromedioNotas()
        {
            Console.WriteLine();
            Console.WriteLine(" Promedio de Notas");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine($" Promedio de notas : {(Notas / contador):F1}");
        }
        }
    }

