using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
{
    class Program
    {
        static double f(double x)
        {
            if ((x * x * x - 1)<0 || (x * x - 1)<0) throw new System.ArgumentException("Квадратный корень из отрицательного числа");
            if ((x * x - 1)==0) throw new System.ArgumentException("Деление на ноль");
            else return Math.Sqrt(x * x*x - 1) / Math.Sqrt(x * x - 1);
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                double x = a, y = 0;
                while (x <= b)
                    try
                    {
                        y = f(x);
                        Console.WriteLine("x = {0} y = {1}", x, y);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("x = {0} error: {1}", x, ex.Message);
                    }
                    finally
                    {
                         x += h;
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadKey();
        }
    }
}
