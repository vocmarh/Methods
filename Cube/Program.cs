using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба, в м");
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            GetVolumeSquare(a, out V, out S);
            Console.WriteLine("Объем куба равен: {0} м3\nПлощадь поверхности куба равна: {1} м2", V, S);
            Console.ReadKey();
        }

        static void GetVolumeSquare(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = Math.Pow(a, 2) * 6;
        }
    }
}
