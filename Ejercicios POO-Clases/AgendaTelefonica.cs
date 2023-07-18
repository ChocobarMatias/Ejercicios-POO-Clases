using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
    /*8- Crea una clase “AgendaTelefonica” con propiedades para
      “nombre” “direccion””telefono”y un vector de contactos .
      Agrega metodos para introducir un contacto a la agenda, 
      buscar un contacto por nombre y mostrar todos los contactos 
      de la agenda.*/

   public class AgendaTelefonica
    {
        string[] Contacto = new string[3];

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        //public string[] Contacto { get; set; }

        int largo;

        //Constructor
        public AgendaTelefonica()
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
        }

        //Metodo introducir un contacto a la agenda
        public void AgregarContacto(int cantidadContactos)//cantidad de contactos es la cantidad contada de 3 en 3
        {                //osea 1 contaccto tiene posicion 1 -nombre 2 -direccion y 3- telefono, el contacto 2 comienza con la siguitene osea 4 -nombre - etc.etc.
            int cont = 0;
            int aux = 0;
            //largo = 3;
            //string[] Contacto = new string[3];
            do
            {
                
                if (cont == 0)
                {
                    Console.WriteLine(" Ingresar 1° contacto");
                    Console.WriteLine(" ---------------------");
                    for (int i = 0; i < Contacto.Length; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write(" Nombre = ");
                            this.Nombre = Console.ReadLine();
                            Contacto[i] = Nombre;
                            Console.Write($" {Contacto[i]} ");
                            //Console.WriteLine($"{Contacto[cont]} 11{cont}");
                        }
                        if (i == 1)
                        {
                            Console.Write(" Direccion = ");
                            this.Direccion = Console.ReadLine();
                            Contacto[i] = Direccion;
                            //Console.WriteLine($"{Contacto[cont]} 11{cont}");
                        }
                        if (i == 2)
                        {
                            Console.Write(" Telefono = ");
                            this.Telefono = Console.ReadLine();
                            Contacto[i] = Telefono;
                            //Console.WriteLine($"{Contacto[cont]} 11{cont}");
                            aux = i;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine($"  - Contacto {cont+1} guardado correctamente");
                }
                else {

                    //cont++;
                    if (cont > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Ingresar {cont+1}° contacto");
                        largo = 3 * aux;
                      Contacto = new string[largo];
                        
                        Console.WriteLine("  ------------------------------");
                        for (int i = aux + 1; i < Contacto.Length; i++)
                        {
                            //Console.Write(" largo = " + largo);
                            if (i == aux + 1)
                            {
                              //  Console.Write(" ii = "+i);
                                Console.Write(" Nombre = ");
                                this.Nombre = Console.ReadLine();
                                Contacto[i] = this.Nombre;
                                Console.Write($" {Contacto[i]} ");
                            }
                            if (i == aux + 2)
                            {
                                Console.Write(" Direccion = ");
                                this.Direccion = Console.ReadLine();
                                Contacto[i] = Direccion;
                            }
                            if (i == aux + 3)
                            {
                                Console.Write(" Telefono = ");
                                this.Telefono = Console.ReadLine();
                                Contacto[i] = Telefono;
                                aux = i;
                            }
                        }

                    }
                }
            
                cont++;
                } while (cantidadContactos != cont);
            }
        
        //Metodo Buscar contacto por nombrea
        public void BuscarContacto(string buscar)
        {// Console.WriteLine(" hola");
           // Contacto = new string[largo];
                Console.WriteLine($" Buscar : {buscar}");
                Console.WriteLine(" ------------------");
                Console.WriteLine();

            for (int i = 0; i < Contacto.Length; i++)
            {
                
                if (buscar == Contacto[i])
                {
                    Console.WriteLine($"Contacto encontrado : {Contacto[i]} numero {i+1}");
                }
            }
        }
        
        //Metodo mostrar todos los contactos
        public void MostrarContactos(string nombre)
        {
            
            Console.Write(" Mostrar Agenda = ");
            for (int i = 0; i < Contacto.Length; i++)
            {
                Console.Write($" {Contacto[i]} ");
                //Console.Write($" {Nombre } ");
            }
        }

    }
}
