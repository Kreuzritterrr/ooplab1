using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Введите x для вычисления y=ln(lg(e^x))-0.35\nx=";
            Console.Write(a);
            double x = double.Parse(Console.ReadLine());
            double y = Math.Log(Math.Log10(Math.Exp(x))) - 0.35;
            Console.Write("y=" + y);
            Console.ReadKey();
        }
    }
}
