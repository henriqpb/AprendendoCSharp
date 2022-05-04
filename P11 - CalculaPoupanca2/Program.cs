using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");



        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " vc tem R$ " + investimento);

            mes += 1;
        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes ++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " vc tem R$ " + investimento);

        }

        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
    }
}
