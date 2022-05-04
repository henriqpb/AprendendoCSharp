using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio for 01");



        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            { 
                Console.WriteLine(numero);
            }
        }

        /* ou

        for (int i=3; i<=100; i+=3 )
        {
                Console.WriteLine(i);
        }
        */
        

        Console.WriteLine("Tecle Enter para sair");
        Console.ReadLine();
    }
}
