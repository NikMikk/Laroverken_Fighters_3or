using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops_Csharpskolan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            //for (int i = 0; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Övning 2
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Övning 3
            //for (int i = 0; i < 52; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //Övning 4 
            //for (int i = 0; i < 52; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //Övningar för for loopen

            //Övning 1
            //Console.Write("Mata in start:");
            //int start = int.Parse(Console.ReadLine());
            //
            //Console.Write("Mata in stop:");
            //int stop = int.Parse(Console.ReadLine());
            //
            //Console.Write("Mata in steg:");
            //int steg = int.Parse(Console.ReadLine());
            //
            //for (int i = start; i <= stop; i+= steg)
            //    Console.Write(i + " ");

            //Övning 3
            //Console.Write("Mata in ett heltal:");
            //int heltal = int.Parse(Console.ReadLine());
            //int summa = 0;
            //
            //for (int i = 1; i <= heltal; i++)
            //    summa += i;
            //
            //Console.WriteLine("Summan av alla tal från 1 till " 
            //                  + heltal + " blir: " + summa);


            //Övning 4
            Console.Write("Mata in ett heltal:");
            int heltal = int.Parse(Console.ReadLine());

            for (int i = 1; i < heltal; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("Talet " + i + " jämt delbart med både 3 och 7");
                }
            }

            Console.ReadKey();
        }
    }
}
