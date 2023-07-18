using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO_Clases
{
    /*5- Crea una clase “CuentaBanco” con propiedades para el 
     “numero de cuenta” “titular” y el “saldo’.Agrega metodos 
     para depositar y retirar dinero de la cuenta.*/

    public class CuentaBanco
    {
       //propiedades y atributos
        public string Nombre { get; set; }
        public int Titular { get; set; }
        public int Saldo { get; set; }

        //Metodo Depositar
        //Agrego Dinero

           

        public void Depositar(int dinero)

        {
            Console.WriteLine(" Deposito de dinero");
            Console.WriteLine(" ------------------");
            Console.WriteLine();
            this.Saldo += dinero;//esta variable  le indica que agregara dinero al saldo
            Console.WriteLine($"    Agrego ${dinero} a su cuenta");
            Console.WriteLine();
            Console.WriteLine($"    Su saldo es : {Saldo}");
            Console.WriteLine();

        }

        //Metodo Retirar dinero de la cuenta
        public void RetirarDinero(int dinero)
        {
            this.Saldo -= dinero;//aqui quito dinero
            Console.WriteLine(" Retiro de Dinero");
            Console.WriteLine(" ------------------");
            Console.WriteLine();
            Console.WriteLine($"    Retiro ${dinero}");
            Console.WriteLine();
            Console.WriteLine($"    Su saldo es : ${Saldo}");
        }
    
    }
}
