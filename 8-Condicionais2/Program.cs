using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        // && e || ou

        if (idadeJoao >= 18 && grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Nao pode entrar!");
        }


        // exe01
        //int idade = 68;
        //bool ehIdoso = idade >= 65;

        //Console.WriteLine(ehIdoso);





        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
