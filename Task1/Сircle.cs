using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     static class Сircle
     { 
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public string GetPoint(double x, double y, double r)

        {
           
           double h = Math.Sqrt(x * x + y * y);

            if (h > r)
    
                return "Точка не принадлежит окружности";
            
            else
               return "Точка принадлежит окружности";
            }
        }

    }
     

