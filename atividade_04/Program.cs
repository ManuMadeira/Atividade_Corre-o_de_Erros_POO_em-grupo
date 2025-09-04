using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número de 1 a 7: ");
        string entrada = Console.ReadLine();
        int dia = int.Parse(entrada);  //Conversão para o switch.


        switch (dia)   //Variável "diaa" não existe.
                       //Alterado para "(dia)".
        {                                       //switch usa string, mas os case eram números int.
            case 1:                             //Converter entrada para int.
                Console.WriteLine("Domingo");
                break;                          //Faltaram ";" ao final das instruções.
            case 2:                             //Mistura de tipos, "2" é string.
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido");     //Faltou ";" no final. Colocado.
                break;
        }
    }
}
