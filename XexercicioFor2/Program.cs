using System;

class Program
{
    static void Main(string[] args)
    {

        //Exercicio Fatorial

        Console.WriteLine("Exercicio for 02");

        int fatorial = 1;

        for (int i = 1; i<11; i++)
        {
            fatorial *= i;  
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }


        // num *= x  => num = num * x

        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
    }
}
