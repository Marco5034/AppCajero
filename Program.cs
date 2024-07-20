using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Declaramos variables 
            int SI, opc;

            float din, dan, S;

            SI = 1000;

            Console.WriteLine("Bienvenido a su cajero virtual");

            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1.Ingreso una cuenta");
            Console.WriteLine("2.Reintegro");
            Console.WriteLine("3.Ver el saldo");
            Console.WriteLine("0.Salir");
            Console.ReadLine();




            opc = Convert.ToInt32(Console.ReadLine());

            
            if (opc == 1)
            {
                Console.WriteLine("Bien, escriba el dinero que desee introducir: ");
                din = float.Parse(Console.ReadLine());

                S = SI + din;
                Console.WriteLine("Ingreso realizado correctamente. Su saldo actual es de $" + S);
                Console.ReadLine();

            }
            else if (opc == 2)
            {
                Console.WriteLine("Ahora , teclee la cantidad de capital que desea retirar:");
                dan = Convert.ToInt32(Console.ReadLine());


                if (dan > SI)
                {
                    Console.WriteLine(" No dispone de tanto sueldo");
                    Console.ReadLine();
                }
                else
                {
                    S = SI - dan;
                    Console.WriteLine("Reintegro realizado correctamente. Su saldo es de:" + S);
                    Console.ReadLine();

                }
            }
            else if (opc == 3)
            {
                Console.WriteLine("Su saldo actual es de $:" + SI);
                Console.ReadLine();

            }
            else if (opc == 0)
            {
                Console.WriteLine("Gracias por utilizar este programa");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Disculpe se ha equivocado al marcar");
            }
        }
    }
}
