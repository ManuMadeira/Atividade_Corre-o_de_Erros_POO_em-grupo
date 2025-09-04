// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
{
    Console.WriteLine("Digite sua Idade: ");
    int idade = int.Parse(Console.ReadLine()!);
        //Erro 1: Faltou o ! que afirma que o valor não será NULO

        if (idade >= 18)
        //Erro 2: if(idade => 18) está incorreto o certo é colocar o sinal de > antes do =;
        //Erro 3: if(idade => 18); com ponto e vírgula no final o correto é sem.
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}
