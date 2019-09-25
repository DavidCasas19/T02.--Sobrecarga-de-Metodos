using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Operacion
    {
        
        public void SC()
        {
            int x1 = Suma(1, 2, 3);
            Console.WriteLine("La respuesta de la sobrecarga es "+"  "+ x1);
            Console.WriteLine("   ");
            Console.ReadKey();

            int x2 = Suma(1, 2);
            Console.WriteLine("La respuesta de la sobrecarga es " + "  " + x2);
            Console.WriteLine("   ");
            Console.ReadKey();

            int x3 = Suma(1);
            Console.WriteLine("La respuesta de la sobrecarga es " + "  " + x3);
            Console.WriteLine("   ");
            Console.ReadKey();

            int x4 = Suma();
            Console.WriteLine("La respuesta de la sobrecarga es " + "  " + x4);
            Console.WriteLine("   ");
            Console.ReadKey();
        }

        public static int Suma(int a,int b,int c)
        {
            return a + b + c;

        }

        public static int Suma(int a, int b)
        {
            return a + b;

        }

        public static int Suma(int a)
        {
            return a + 3;

        }

        public static int Suma()
        {
            return 1;

        }
    }
}
