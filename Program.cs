using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practika2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task1();
            // Task2();
            Task3();

            void Task1()
            {
                int even = 0;
                int odd = 0;
                int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
                Console.WriteLine("Количество четных членов равно: " + even);
                Console.WriteLine("Количество нечетных членов равно: " + odd);
                Console.ReadLine();
            }

            void Task2()
            {
                int[] a = { 1, 2, 3, 4, 5, 6 };
                int input = Convert.ToInt32(Console.ReadLine());
                int number = 0;

                foreach (int i in a)
                {
                    if (i < input)
                    {
                        number++;
                    }
                }
                Console.WriteLine("Чисел в массиве меньше " + input + ": " +number); 
                Console.ReadLine();
            }

            void Task3()
            {
                int[] a = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

                int input = Convert.ToInt32(Console.ReadLine());
                int input1 = Convert.ToInt32(Console.ReadLine());
                int input2 = Convert.ToInt32(Console.ReadLine());
                
                int number = 0;

                for (int i = 0; i < a.Length; i++) {
                    if (a[i] == input && a[i+1] == input1 && a[i+2] == input2) {
                    number++;
                    }

                    Console.WriteLine(number);
                    Console.ReadLine();
                }

            }
        }
    }
}
