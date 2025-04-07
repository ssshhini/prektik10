using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа номер 10");
            Console.WriteLine("1 - 30");
            int input = Convert.ToInt32(Console.ReadLine());

            int a, n, x, m;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Введите целое число:");
                     a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите целую степень:");
                     n = Convert.ToInt32(Console.ReadLine());

                    Tusk1 calculator1 = new Tusk1();
                    double pow = calculator1.Calculator(a, n);

                    Console.WriteLine($"Число А в степени N: {pow}");
                    Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("Введите целое число");
                     n = int.Parse(Console.ReadLine());

                    Tusk2 calculator2 = new Tusk2();
                    long  factorial = calculator2.CalculateFactorial((int)n);

                    Console.WriteLine($"Фаркториал {n} = {factorial}");
                    Console.ReadLine();

                    break;

                case 3:

                    Tusk3 calculator3 = new Tusk3();
                    calculator3.Calculate();

                    break;

                case 4:

                    Tusk4 calculator4 = new Tusk4();
                    calculator4.Calculate();

                    break; 

                case 5:
                    Tusk5 calculator5 = new Tusk5();
                    calculator5.Calculate();

                    break;

                case 6:

                    Tusk6 calculator6 = new Tusk6();
                    calculator6.Calculate();

                    break;

                case 7:

                    Tusk7 calculator7 = new Tusk7();
                    calculator7.Calculate();

                    break;

                case 8:

                    Tusk8 calculator8 = new Tusk8();
                    calculator8.Calculate();

                    break;

                case 9:
                    Tusk9 calculator9 = new Tusk9();
                    calculator9.Calculate();
                    break;

                case 10:
                    Tusk10 calculator10 = new Tusk10();
                    calculator10.Calculate();
                    break;

                case 11:
                    Tusk11 calculator11 = new Tusk11();
                    calculator11.Calculate();
                    break;

                case 12:
                    Tusk12 calculator12 = new Tusk12();
                    calculator12.Calculate();
                    break;

                case 13:
                    Tusk13 calculator13 = new Tusk13();
                    calculator13.Calculate();
                    break;

                case 14:
                    Tusk14 calculator14 = new Tusk14();
                    calculator14.Calculate();
                    break;

                case 15:

                    Tusk15 calculator15 = new Tusk15();
                    calculator15.Calculate();
                    break;

                case 16:
                    Tusk16 calculator16 = new Tusk16();
                    calculator16.Calculate();
                    break;

                case 17:
                    Tusk17 calculator17 = new Tusk17();
                    calculator17.Calculate();
                    break;

                case 18:
                    Tusk18 calculator18 = new Tusk18();
                    calculator18.Calculate();
                        break;

                case 19:
                    Tusk19 calculator19 = new Tusk19();
                    calculator19.Calculate();
                    break;

                case 20:
                    Tusk20 calculation20 = new Tusk20();
                    calculation20.Calculate();
                    break;

                case 21:
                    Tusk21 calculation21 = new Tusk21();
                    calculation21.Calculate();
                    break;

                case 22:
                    Tusk22 calculation22 = new Tusk22();
                    calculation22.Calculate();
                    break;

                case 23:
                    Tusk23 calculation23 = new Tusk23();
                    calculation23.Calculate();
                    break;

                case 24:
                    Tusk24 calculation24 = new Tusk24();
                    calculation24.Calculate();
                    break;

                case 25:
                    Tusk25 calculation25 = new Tusk25();
                    calculation25.Calculate();
                    break;

                case 26:
                    Tusk26 calculation26 = new Tusk26();
                    calculation26.Calculate();
                    break;

                case 27:
                    Tusk27 calculation27 = new Tusk27();
                    calculation27.Calculate();
                    break;

                case 28:
                    Tusk28 calculation28 = new Tusk28();
                    calculation28.Calculate();
                    break;

                case 29:
                    Tusk29 calculation29 = new Tusk29();
                    calculation29.Calculate();
                    break;

                case 30:
                    Tusk30 calculation30 = new Tusk30();
                    calculation30.Calculate();
                    break;
            }
        }
    }
}