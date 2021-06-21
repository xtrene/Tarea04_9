using System;

namespace Tarea04_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Los primeros 100 números pares: ");
            while (num < 100)
            {
                num++;
                if (num%2 == 0)
                {
                    Console.Write(" " + num);
                }
                
            }



            Console.ReadKey();
        }
    }
}
