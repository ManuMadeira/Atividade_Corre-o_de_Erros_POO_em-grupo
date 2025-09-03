using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Por favor, digite seu primeiro nome:") // E1 - Sintatese , falta ;
        Console.WriteLine("Por favor, digite seu primeiro nome:");
        string primeiroNome = Console.ReadLine()!;   //CS8600 - afirmando que o valor não será nulo
        Console.WriteLine("Agora, digite sua idade:");
        //int idade = Console.ReadLine(); // CS0029 - E2 - TIPAGEM (Converta com int.Parse,Convert.ToInt32 ou int.TryParse)
        int idade = int.Parse(Console.ReadLine()!); // ! afirmando que o valor não será nulo
        Console.WriteLine("Por fim, digite sua altura em metros (ex: 1,80):");
        float altura = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture); //CS8604 - ! afirmando que o valor não será nulo, Alem do CultureInfo.InvariantCulture para a altura
                                                                                       //Console.writeline($"Resumo do Cadastro: Nome: {PrimeiroNome}, Idade: {idade} anos, Altura: {altura}m.") //E6 - CS0103 -String "primeironome esta ecrita diferente de como foi nomenclata"
                                                                                       //E5 - CS0117 - Console. nao tem a definição writeline, deveria ser WriteLine, com as respectivas letras maisusculas
        Console.WriteLine($"Resumo do Cadastro: Nome: {primeiroNome}, Idade: {idade} anos, Altura: {altura.ToString("0,00", CultureInfo.InvariantCulture)}m.");
    }

}