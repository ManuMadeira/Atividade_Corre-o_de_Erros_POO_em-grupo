using System;
class Program
{
    static void Main()
    {
        //Erro 1: float[] notas = new float[5];, o correto é como float.
        //Correto
        float[] notas = new float[5];

        //Erro 2: for (int i = 0; i <= notas.Length; i++), esta com menor e igual (<=), o correto é só < que vai ler 0 a 4.
        //Correto:
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a nota {i + 1}: ");
        //Erro 3: notas[i] = int.Parse(Console.ReadLine()); notas não vai receber valor inteiro e sim um valor real ou seja float, e faltou ! para dizer que não sera NULO.
            //Correto:
            notas[i] = float.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < notas.Length; i++)
        {
            //Erro 4: string situacao = notas[i] == 7 ? "Aprovado" : "Reprovado";, o correto é >= assim o programa vai ler numeros maiores eo 7.
            //Correto:
            string situacao = notas[i] >= 7 ? "Aprovado" : "Reprovado";

            //Erro 5: faltou acrecentar o :F2 (exemplo:notas[i]:F2), assim mesmo se a nota tiver mais que 2 casas após a vírgula ele só vai ler dois numeros (exemplo: 7,65).
            //Correto:
            Console.WriteLine($"Nota {i + 1}: {notas[i]:F2} - {situacao}");
        }
    }
}