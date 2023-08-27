using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungsaufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 ggt berechnen");
                Console.WriteLine("2 kgv berechnen");
                Console.WriteLine("3 kgt rekrusiv berechnen");
                Console.WriteLine("4 arithmetischer Mittelwert kleinster Wert grösster Wert ausrechnen ");
                Console.WriteLine("5 Variabeln vertauschen");
                Console.WriteLine("3 Inhalt eines Array vertauschen");
                Console.WriteLine("5 Beenden");
                int choice = MyMath.ReadInt("Wählen eine Option: ");

                if (choice == 1) 
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int gcd = MyMath.Calc_ggT(a, b);
                    MyMath.ShowResult("ggT", a, b, gcd); 
                }
                else if (choice == 2) {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int lcm = MyMath.Calc_kgV(a, b);
                    MyMath.ShowResult("KgV", a, b, lcm);
                }
                else if(choice == 3)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int lcm = MyMath.Calc_ggT_r(a, b);
                    MyMath.ShowResult("KgV", a, b, lcm);
                }

                else if(choice == 4)
                {
                    Console.WriteLine("Programm wird beendet");
                    break;
                }



            }
        }
    }
}



