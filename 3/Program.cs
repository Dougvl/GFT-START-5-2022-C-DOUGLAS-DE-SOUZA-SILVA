using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Trabalhador> listaTrabalhadores = new List<Trabalhador>();

            Console.Write("Quantidade de Trabalhadores: ");
            int inserirQntTrabalhadores = int.Parse(Console.ReadLine());
            Console.WriteLine();
            

            for(int i = 0; i<inserirQntTrabalhadores; i++)
            {
                Trabalhador trabalhador = new Trabalhador();
                Console.Write("Nome: ");
                trabalhador.SetNome(Console.ReadLine());
                Console.Write("Salário por hora: ");
                trabalhador.SetSalarioPorHora(double.Parse(Console.ReadLine()));
                Console.Write("Horas Trabalhadas: ");
                trabalhador.SetHorasTrabalhadas(int.Parse(Console.ReadLine()));
                listaTrabalhadores.Add(trabalhador);
                Console.WriteLine();

            }

            Console.Write("Nome do trabalhador que quer consultar: ");
            string nomeConsulta = Console.ReadLine();
            Console.WriteLine();

            foreach (var trab in listaTrabalhadores)
            {
                if(nomeConsulta == trab.GetNome())
                {
                    Console.WriteLine("Nome: " + trab.GetNome());
                    Console.WriteLine("Salario Hora: " + trab.GetSalarioPorHora());
                    Console.WriteLine("Horas Trabalharas: " + trab.GetHorasTrabalhadas());
                    Console.WriteLine("Total: " + trab.GetSalarioTotal());
                    Console.WriteLine();
                }
                
            }
        Console.ReadKey();
        }
    }
}
