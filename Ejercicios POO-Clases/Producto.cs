using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
    /*4- Crea una clase “Producto”  con propiedades para “nombre” 
     “precio” y “cantidad disponible”.Agrega metodos para 
     calcular el valor total del inventario y mostrar sus detalles*/

    class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int CantidadDisponible { get; set; }
        //Constructor
        public Producto(string nombre, int precio, int cantidadDisponible)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.CantidadDisponible = cantidadDisponible;
        }
        public void DetallesProducto()
        {
            Console.WriteLine();
            Console.WriteLine("Detalle del producto");
            Console.WriteLine();
            Console.WriteLine($" El producto {Nombre}");
            Console.WriteLine($"El precio del producto es ${Precio}");
            Console.WriteLine($" El Stock =  {CantidadDisponible}");
            Console.WriteLine();
        }
        public void valorTotal()
        {
            
            Console.WriteLine($" El valor del inventario es : ${Precio * CantidadDisponible}");
        }
    }
}
