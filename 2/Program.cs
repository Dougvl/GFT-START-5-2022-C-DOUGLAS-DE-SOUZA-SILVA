using System;
using teste2.Models;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1500;
            int trinta = 30;
            int sessenta = 60;
            int noventa = 90;
            int duzentos = 200;

            Cheque cheque30dias = new Cheque(trinta);
            Cheque cheque60dias = new Cheque(sessenta);
            Cheque cheque90dias = new Cheque(noventa);
            Cheque cheque200dias = new Cheque(duzentos);
                            
            System.Console.WriteLine($"Cheque no {valor} e prazo de {trinta} dias, valor R$:" + cheque30dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Cheque no {valor} e prazo de {sessenta} dias, valor R$:"+ cheque60dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Cheque no {valor} e prazo de {noventa} dias, valor R$:"+ cheque90dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Cheque no {valor} e prazo de {duzentos} dias, valor R$:"+ cheque200dias.calcularValorRecebivel(valor));

            Promissoria Promissoria30dias = new Promissoria(trinta);
            Promissoria Promissoria60dias = new Promissoria(sessenta);
            Promissoria Promissoria90dias = new Promissoria(noventa);
            Promissoria Promissoria200dias = new Promissoria(duzentos);

            System.Console.WriteLine($"Promissoria no {valor} e prazo de {trinta} dias, valor R$:" + Promissoria30dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Promissoria no {valor} e prazo de {sessenta} dias, valor R$:"+ Promissoria60dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Promissoria no {valor} e prazo de {noventa} dias, valor R$:"+ Promissoria90dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Promissoria no {valor} e prazo de {duzentos} dias, valor R$:"+ Promissoria200dias.calcularValorRecebivel(valor));

            TituloDoGoverno TituloDoGoverno30dias = new TituloDoGoverno(trinta);
            TituloDoGoverno TituloDoGoverno60dias = new TituloDoGoverno(sessenta);
            TituloDoGoverno TituloDoGoverno90dias = new TituloDoGoverno(noventa);
            TituloDoGoverno TituloDoGoverno200dias = new TituloDoGoverno(duzentos);

            System.Console.WriteLine($"Titulo do Governo no {valor} e prazo de {trinta} dias, valor R$:" + TituloDoGoverno30dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Titulo do Governo no {valor} e prazo de {sessenta} dias, valor R$:"+ TituloDoGoverno60dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Titulo do Governo no {valor} e prazo de {noventa} dias, valor R$:"+ TituloDoGoverno90dias.calcularValorRecebivel(valor));
            System.Console.WriteLine($"Titulo do Governo no {valor} e prazo de {duzentos} dias, valor R$:"+ TituloDoGoverno200dias.calcularValorRecebivel(valor));
        }
    }
}
