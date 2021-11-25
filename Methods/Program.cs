using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стороны первого треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double P1, S1;
            Console.WriteLine("Стороны второго треугольника");
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            double P2, S2;
            GetSquare1(a, b, c, out P1, out S1);
            GetSquare2(d, e, f, out P2, out S2);
            Console.WriteLine(S1);
            Console.WriteLine(S2);
            double z = S1 < S2 ? S2 : S1;
            Console.WriteLine("Площадь большего треугольника равна {0}", z);
            Console.ReadKey();
            
        }

        static void GetSquare1(int a, int b, int c, out double P1, out double S1)
        {
            P1 = (a + b + c) / 2;
            S1 = Math.Sqrt(P1 * (P1 - a) * (P1 - b) * (P1 - c));
        }
        static void GetSquare2(int d, int e, int f, out double P2, out double S2)
        {
            P2 = (d + e + f) / 2;
            S2 = Math.Sqrt(P2 * (P2 - d) * (P2 - e) * (P2 - f));
        }

    }
}
