using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matriz = new int [4,4];

            for (int i =0;i<4;i++)
            {
                for (int j =0;j<4;j++)
                {
                    Console.WriteLine("Digite um numero da matriz: " + i + ":" + j);
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i =0;i<4;i++)
            {
                for (int j =0;j<4;j++)
                {
                    if (i == 0 && j ==0)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i+1,j] + " " + matriz[i,j+1] );
                    
                    }
                    if (i > 0 && i < 3 &&  j == 0 && j < 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i-1,j]  + " " + matriz[i,j+1] +" "+ matriz[i+1,j]);
                    
                    }
                   
                    if (i > 0 && i < 3 &&  j > 0 && j < 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i,j-1] +" " + matriz[i-1,j] +" "+ matriz[i+1,j] + " " + matriz[i,j+1] );
                    
                    }

                    if (i == 0 && j == 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i,j-1] +" "+ matriz[i+1,j]);
                    
                    }
                    if (i > 0 && i < 3  && j == 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i-1,j] +" "+ matriz[i+1,j] +" " + matriz[i,j-1]);
                    
                    }
                    if (i == 3  && j == 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i-1,j] +" "+ matriz[i,j-1]);
                    
                    }
                    if (i == 3  && j > 0 && j < 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i,j-1] +" "+ matriz[i,j+1]+ " "+ matriz[i-1,j]);
                    
                    }
                    if (i == 0  && j > 0 && j < 3)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i,j-1] +" "+ matriz[i,j+1]+ " "+ matriz[i+1,j]);
                    
                    }
                    if (i == 3  && j == 0)
                    {
                        Console.WriteLine("Na posicao " + i + ":" + j + " os numeros das posicoes : " + matriz[i,j+1]+ " "+ matriz[i-1,j]);
                    
                    }
                    
                }
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
