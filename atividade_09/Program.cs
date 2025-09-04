int[,] matriz = new int[3, 3];
int somaTotal = 0;
int somaDiagonal = 0;
int[] maiores = new int[3];

for (int i = 0; i < 3; i++)
{
    maiores[i] = int.MinValue;          //Se todos os valores da linha forem negativos o 0 é identificado como maior
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Valor [{i},{j}]: ");
        int valor = int.Parse(Console.ReadLine());

        matriz[i, j] = valor;
        somaTotal += valor;

        if (i == j)
        {
            somaDiagonal += matriz[i, i];       //Os valores da diagonal principal não correspondem
        }

        if (valor > maiores[i])
        {
            maiores[i] = valor;
        }
    }
}

Console.WriteLine($"Soma total: {somaTotal}");                        //Várias instruções Console.WriteLine sem ";" no final
Console.WriteLine($"Soma diagonal principal: {somaDiagonal}");

Console.WriteLine("Maiores por linha:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(maiores[i]);
}

int[,] transposta = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        transposta[j, i] = matriz[i, j];        //Estava copiando a matriz original, agora foi corrigido
    }
}

Console.WriteLine("Matriz transposta:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(transposta[i, j] + " ");
    }
    Console.WriteLine();
}
