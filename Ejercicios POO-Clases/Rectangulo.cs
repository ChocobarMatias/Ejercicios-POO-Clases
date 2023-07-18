using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
    /*3- Crea una clase “Rectangulo” con propiedades para el ancho
      y el alto y un metodo en el que debas calcular el area de 
      rectangulo.*/
    class Rectangulo
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public Rectangulo(int alto, int Ancho)
        {
            this.Alto = alto;
            this.Ancho = Ancho;
        }
        public void AreaRectangulo()
        {
            Console.WriteLine($"El Area de Rectangulo = {Alto * Ancho}");
        }
    }
}
