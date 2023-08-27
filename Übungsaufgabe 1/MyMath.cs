using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungsaufgabe_1
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
       public static int Calc_kgV(int a, int b)
       {
            int gcd = Calc_ggT(a, b);
            return a * b / gcd;
        }
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
          return Calc_ggT(b, a%b);

        }
        public static int ReadInt(string promt)
        {
            Console.WriteLine(promt);
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
            }
        }
        public static void ShowResult(string operation, int a, int b, int result) 
        {
            Console.WriteLine($"{operation} von {a} und {b} ist {result}");
        }

        internal static int Calc_ggT(int a, object b)
        {
            throw new NotImplementedException();
        }
        public static double CalculateMean(int[] numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
        public static int FindMinValue(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }
        public static int FindMaxValue(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

    }

 
    
}
