using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 4
               Se citeste de la tastatura un vector continant n numere intregi, 
               n fiind si el citit la randul sau citit de la tastatura. 
               Scrieti functii care vor returna:
               • Cel mai mare numar din vector
               • Cel mai mic numar din vector
               • Numerele divizibile cu 3
               • Numerele prime din vector
              */

            Console.WriteLine("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Maximul este: {MaxNumber(arr)}");

            static int MaxNumber(int[] arrMax)
            {
                int max = 0;
                int number = 0;
                for (int i = 0; i < arrMax.Length; i++)
                {
                    if (arrMax.Length > 0)
                    {
                        number = arrMax[i];

                        if (number > max)
                        {
                            max = number;
                        }
                    }
                }

                return max;
            }

            Console.WriteLine($"Minimul este: {MinNumber(arr)}");
            static int MinNumber(int[] arrMin)
            {
                int min = 0;
                int number = 0;
                for (int i = 0; i < arrMin.Length; i++)
                {
                    if (arrMin.Length > 0)
                    {
                        number = arrMin[i];

                        if (number > min)
                        {
                            min = number;
                        }
                    }
                }

                return min;
            }


            NumberDivisibleByThree(arr);
            static void NumberDivisibleByThree(int[] arr)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 3 == 0)
                    {
                        Console.WriteLine($"Numerele sunt: {arr[i]}");
                    }
                }

            }


            NumerePrime(arr);
            static void NumerePrime(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % (i + 1) != 0)
                    {
                        Console.WriteLine($"Numerele sunt: {arr[i]}");
                    }
                }

            }

        }
    }
}
