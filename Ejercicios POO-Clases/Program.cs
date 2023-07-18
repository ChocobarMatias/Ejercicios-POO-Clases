using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios_POO_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("================");
            Console.WriteLine(" - Estudiante - ");
            Console.WriteLine("================");
            Console.WriteLine();
            Estudiante nuevoEstudiante = new Estudiante();
            nuevoEstudiante.Nombre = "Matias";
            nuevoEstudiante.Apellido = "Chocobar";
            nuevoEstudiante.Edad = 38;
            nuevoEstudiante.Legajo = 59234;
            nuevoEstudiante.DetallesEstudiante();

            Estudiante estudia = new Estudiante();
            estudia.Nombre = "Matias";
            estudia.Apellido = "Chocobar";
            estudia.Estudiar();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");

            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine(" - Profesor - ");
            Console.WriteLine("==============");
            Console.WriteLine();
            Profesor nuevoProfesor = new Profesor("Matias", "Chocobar", 38, "Programacion");
            nuevoProfesor.DetallesProfesor();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");

            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine(" - Rectangulo - ");
            Console.WriteLine("==============");
            Console.WriteLine();

            Rectangulo areaRect = new Rectangulo(10, 10);
            areaRect.AreaRectangulo();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");

            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine(" - Producto - ");
            Console.WriteLine("==============");
            Console.WriteLine();

            Producto productos = new Producto("Gaseosa", 20, 50);
            productos.DetallesProducto();
            Console.WriteLine();

            Producto valor = new Producto("Gaseosa", 20, 50);
            valor.valorTotal();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");

            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine(" - Cuenta Bancaria - ");
            Console.WriteLine("=====================");
            Console.WriteLine();

            CuentaBanco dinero = new CuentaBanco();
            dinero.Depositar(1000);

            CuentaBanco sacarDinero = new CuentaBanco();
            sacarDinero.RetirarDinero(1000);

            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==============");
            Console.WriteLine(" - Mascota - ");
            Console.WriteLine("==============");
            Console.WriteLine();
            Mascota MiPerrito = new Mascota();
            MiPerrito.Nombre = " Brako";
            MiPerrito.Edad = 8;
            MiPerrito.Raza = " Labrador";
            MiPerrito.DetallesMascota();

            Console.WriteLine();
            MiPerrito.Alimentar("croquetas");
            Console.WriteLine();
            MiPerrito.Jugar("Pelota");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  ==============");
            Console.WriteLine(" - Estudiante 2 - ");
            Console.WriteLine("  ==============");
            Console.WriteLine();
            Estudiante2 NuevoEstudiant = new Estudiante2();
            NuevoEstudiant.Nombre = " Matias Chocobar";
            NuevoEstudiant.Edad = 38;
            NuevoEstudiant.Legajo = 59234;
            NuevoEstudiant.DetalleEstudiante2(5);
            Console.WriteLine();
            NuevoEstudiant.PromedioNotas();
            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  =====================");
            Console.WriteLine(" - Agenda Telefonica - ");
            Console.WriteLine("  =====================");
            Console.WriteLine();
            AgendaTelefonica NuevoContacto = new AgendaTelefonica();
          
            NuevoContacto.AgregarContacto(1);
            Console.WriteLine();
            NuevoContacto.BuscarContacto("matias");
            Console.WriteLine();
            NuevoContacto.MostrarContactos("matias");
            Console.ReadKey();
          
        }
    }
}
