using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilangan_Prima
{

    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class program dapat membuat operasi menentukan bilangan prima</remarks>
    class Program
    {
        /// <summary>
        /// operasi menentukan bilangan prima
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int angka;
            int i, x;
            Console.WriteLine("Program Sederhana Bilangan Prima");
            Console.Write("Masukkan Angka =");
            angka = int.Parse(Console.ReadLine());
            if (angka == 1)
            {
                Console.WriteLine("Bukan Bilangan Prima");
            }
            else if (angka == 2)
            {
                Console.WriteLine("Bilangan Prima");
            }

            else
            {
                for (i = 2; i < angka; i++)
                {
                    x = angka % i;

                    if (x == 0)
                    {
                        Console.WriteLine("Bukan Bilangan Prima");

                        Console.Read();
                    }
                }
                Console.WriteLine("Bilangan Prima");
            }
            Console.ReadKey();
        }
    }
}
