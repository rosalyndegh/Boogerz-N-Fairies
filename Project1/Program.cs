using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LessonOne();
            //LessonTwo();
            LessonThree();
            Console.ReadKey();
        }

        static void LessonOne()
        {
            string words = "Herro World";
            System.Console.WriteLine(words);
            while (true)
            {
                ConsoleKeyInfo key = System.Console.ReadKey(true);

                if (key.KeyChar == 'g')
                {
                    Console.WriteLine("Boogers");
                }
                else
                {
                    Console.WriteLine("fairy");
                }

            }
        }

        static void LessonTwo()
        {
            // -> this will be removed when we compile <-
            int[] alice = new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 15 };

            // "for" loop
            for (int i = 0; i < alice.Length; i++)
            {
                Console.WriteLine(alice[i]);
                //String message = String.Format("Alice[{0}] : {1}", i, alice[i]);
                if (alice[i] % 3 == 0)
                {
                    Console.Write("fizz");
                }
                if (alice[i] % 5 == 0)
                {
                    Console.Write("buzz");
                }
                if (alice[i] % 3 == 0 || alice[i] % 5 == 0)
                {
                    Console.Write("\n"); 
                }
                
                
            }
            Console.ReadKey();
        }

        static void LessonThree()
        {
            //lesson three code
            Nucleus sebastian = new Nucleus(24, 8);
            Console.WriteLine(String.Format("nucleus : {0}, {1}, {2}", sebastian.EnzymeCount, sebastian.NucleotideCount, sebastian.Color));
            
            Console.WriteLine(sebastian);
        }

    }
}

