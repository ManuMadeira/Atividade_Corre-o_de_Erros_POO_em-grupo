using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //double total = "0"; // Tipagem E2 CS0029 valor entre ""
        double total = 0;
        while (total < 50)
        {
            Console.Write("Digite o valor a ser guardado: ");
            //double valor = double.Parse(Console.ReadLine().Replace('.', ',')); //CS8602 - E12 - CultureInfo.InvariantCulture
            double valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture); 
            //total =+ valor;  // E1 - Sintaxe operador incorreto
            total += valor; 
            
        }
        Console.WriteLine($"Meta atingida! Total economizado: R$ {total.ToString("0.00",CultureInfo.InvariantCulture)}"); // E9 interpolaçaõ $ e da E12 formatação do total usando o ToString
    }
}