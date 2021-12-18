using Kapitonov;
using System.Collections.Generic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ввдеите значение аргумента A");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Ввдеите значение аргумента B");
                float b = float.Parse(Console.ReadLine());

                Console.WriteLine("Ввдеите значение аргумента C");
                float c = float.Parse(Console.ReadLine());

                CawaLog.I().log("Вы ввели уравнение " + a + "x^2 + " + b + "x + " + c + " =  0");

                QuadraticEquation function = new QuadraticEquation();
                List<float> mas = function.Solve(a, b, c);

                CawaLog.I().log("Корни введенного вами уравнения " + string.Join(" ; ", mas));
            }
            catch (CawaException ex)
            {
                CawaLog.I().log(ex.Message);
            }

            CawaLog.I().write();

        }
    }
}
