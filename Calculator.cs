using System;
using System.Diagnostics;

namespace lab3
{
    class Program
    {
        static double Func(double x)
        {
            double y = x * x - 8 * x + 20;                 
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите шаг построения: ");
            string step_str = Console.ReadLine();                 
            double step = Convert.ToDouble(step_str);
            
            Console.WriteLine("Введите диапозон значений X");
            Console.Write("Введите начальный X: "); 
            string X0_str = Console.ReadLine();                 
            double X0 = Convert.ToDouble(X0_str);

            Console.Write("Введите конечный X: ");         
            string X_str = Console.ReadLine();                 
            double X = Convert.ToDouble(X_str);

                        
            for ( double i = X0; i < X; i += step)
            {
                double y = Func(i);
                Console.WriteLine($"X = {i}, Y = {y}");

            }

        }
    }
}
