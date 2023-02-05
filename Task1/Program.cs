using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double length = Сircle.GetLength(r);
            double square = Сircle.GetSquare(r);
            string point = Сircle.GetPoint(x, y, r);
            Console.WriteLine($"{length}\n{square}");
            Console.WriteLine($"{point}"); 
            Console.ReadKey();
        }
    }
}
