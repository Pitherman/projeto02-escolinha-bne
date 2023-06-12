using System;

class Rendimentos
{
    public double valorPresente;
    public double taxa;
    public int periodo;


    public double valorF()
    {
        return (valorPresente*Math.Pow((1+taxa/100), periodo));
    }


    public void tabela()
    {
        int counter = 1;
        while (counter <= 6)
        {
            periodo = counter;
            double rendimento = Math.Round(valorF(), 2);
            double liquido = rendimento - valorPresente;
            Console.WriteLine("["+counter+"º mês] Valor aplicado: R$"+valorPresente+" | Taxa: "+taxa+"% | Rendimento: R$"+rendimento.ToString("0.00")+" | Rendimento Líquido: "+liquido.ToString("0.00")+"");
            counter++;
        }
        
    }
}