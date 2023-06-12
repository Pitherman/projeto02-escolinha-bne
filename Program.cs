using System;

namespace _Teste02

{
    class Program
    {
        static void Main(string[] args)
        {
            Rendimentos r = new Rendimentos();
            Console.WriteLine("Qual o valor investido?");
            r.valorPresente = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a taxa de juros aplicada?");
            r.taxa = Convert.ToDouble(Console.ReadLine());
            r.tabela();
        }

    }

}