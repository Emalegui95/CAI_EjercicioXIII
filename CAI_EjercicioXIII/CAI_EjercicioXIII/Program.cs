using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioXIII
{
    class Program
    {
        static int factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * factorial(num - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int ingreso = int.Parse(Console.ReadLine());

            Console.WriteLine("Su factorial es: " + factorial(ingreso));
            Console.ReadKey(true);
        }
    }
}
