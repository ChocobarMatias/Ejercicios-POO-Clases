using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
   public class Estudiante
    {
        /*1- Crea una clase “Estudiante” con propiedades para “nombre” “apellido” “edad” y
         “Legajo” agrega metodos para mostrar los detalles del estudiante. 
         utiliza la implementacion tradicional de atributos y propiedades de clases.*/

            public string nombre;
            public string apellido;
            public int edad;
            public int legajo;

        //atributos de la clase
        public string Nombre
        {
            get {return nombre; }
            set {nombre = value; }
        }
        //atributos de la clase
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        //atributos de la clase
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        //atributos de la clase
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        //Constructor es lo que necesita la clase para que exista
        //al crear constructor obligo que pida parametros al llamar la clase
        //si no creo constructor se crea uno por defecto sin parametros
        //No tiene tipo y no regresa tipo
  
        //Metodo accion que realiza el estudiante
        public void Estudiar()
        {
            Console.WriteLine($"El estudiante {nombre} {apellido} estudia Programador Universitario ");
        }
        //Metodo accion que realiza el estudiante
        public void practicar()
        {
            Console.WriteLine($"El estudiante {nombre} {apellido} practica como programar ");
        }
        //Metodo accion que realiza el estudiante
        public void Rendir()
        {
            Console.WriteLine($"El estudiante {nombre} {apellido} estudia ");
        }
        //Metodo accion que realiza el estudiante
        public void DetallesEstudiante()
            {
                Console.WriteLine();
                Console.WriteLine("Detalles del Estudiante");
                Console.WriteLine();
                Console.WriteLine($" Nombre y Apellido : {Nombre} {Apellido}");
                Console.WriteLine($" Edad : {Edad}");
                Console.WriteLine($" Legajo : {Legajo}");
                Console.WriteLine();
            }
        

        }
}
