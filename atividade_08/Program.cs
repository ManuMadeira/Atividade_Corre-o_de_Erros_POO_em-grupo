using System;
class Program
{
    static void Main()
    {
        int[] notas = new int[5];

        //Erro 1: for (int i = 0; i <= notas.Length; i++), esta com menor e igual (<=), o correto é só < que vai ler 0 a 4.
        //Correto:
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
            //Erro 2: faltou ! para dizer que o campo não sera NULO.
            //Correto:
            notas[i] = int.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < notas.Length; i++)
        {
            //Erro 3: string situacao = notas[i] == 7 ? "Aprovado" : "Reprovado";, o correto é >= assim o programa vai ler numeros maiores eo 7.
            //Correto:
            string situacao = notas[i] >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"Nota {i + 1}: {notas[i]} - {situacao}");
        }
    }
}