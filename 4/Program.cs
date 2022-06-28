using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero = int.Parse(Console.ReadLine());
            int contador =0;

            for (int i =0; i <= numero;i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                
            }


        }
    }
}
