internal class Program
{
    private static void Main(string[] args)
    {
        // Erro: 
        //  a matriz deve conter 2 dimensões
        // int[,] matriz = new int[3];
        // Correto:
        int[,] matriz = new int[4, 4];

        for (int i = 0; i <= 3; i++) {
            for (int j = 0; j <= 3; j++) {
                Console.Write($"Valor [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("Número a buscar: ");

        int buscado = int.Parse(Console.ReadLine());

        // Erro: 
        //  o tipo bool não pode receber valores nulos
        // bool encontrado = null;
        // Correto:
        bool encontrado = false;

        int linha = 0, coluna = 0;
        
        for (int i = 0; i <= 3; i++) {
            for (int j = 0; j <= 3; j++) {
                // Erro: 
                //  a comparação estava sendo feita com apenas um (=), isso
                //  representa uma atribuição de valor e não uma comparação.
                // if (matriz[i, j] = buscado) {
                // Correto:
                if (matriz[i, j] == buscado) {
                    // Erro: 
                    //  a atribuição estava sendo feita com dois (==), isso
                    //  representa uma comparação de valores e não uma atribuição.
                    // encontrado == true;
                    // Correto:
                    encontrado = true;
                    linha = j;
                    coluna = i;
                    break;
                }
            }
            if (encontrado) break;
        }
        if (encontrado = true) {
            // Erro: 
            //  writeline está escrito de maneira errada, o correto é WriteLine - código E5 CS0117
            // Console.writeline($"Encontrado em ({linha + 1}, {coluna + 1})");
            // Correto:
            Console.WriteLine($"Encontrado em ({linha + 1}, {coluna + 1})");
        }
        else {
            Console.WriteLine("Número não encontrado: {buscado}");
        }
    }
}