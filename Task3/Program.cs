using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            bool OK=true;
            double x, y;
            do
            {
                Console.WriteLine("Введите координату X:");
                str = Console.ReadLine();
                OK = Double.TryParse(str, out x);
            } while (!OK);
            do
            {
                Console.WriteLine("Введите координату Y:");
                str = Console.ReadLine();
                OK = Double.TryParse(str, out y);
            } while (!OK);
            double k = (double)1 / 3;
            bool InArea = ((x < 0) && (y > (k * x - k)) && (y < (2 * x + 3) && (y < -x)) || ((x >= 0 && x < 1) && (y < 0) && (y > (k * x - k))));
            Console.WriteLine(InArea);
            Console.Read();
        }
    }
}
