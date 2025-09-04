internal class Program
{
    private static void Main(string[] args)
    {
        // Erro:
        //  para que possamos coletar apenas 1 caracter como é feito no loop,
        //  devemos usar uma variável do tipo char - código E2 CS0029
        // string resposta;
        // Correto:
        char resposta;

        do{
            Console.Write("Deseja sair? (S/N): ");
            resposta = Console.ReadLine().ToUpper()[0];
        // Erros: 
        //  1- a lógica está construída de maneira errada, para sairmos quando
        //      o usuário digitar 'S' ou 's', deverá ser feita outra validação. - código E11
        //  2- como a comparação é feita com um campo char, temos de substituir as aspas duplas por aspas simples - código E3
        //  3- por conta de possuirmos um ".ToUpper" diretamente na coleta da resposta, não é necessário comparar
        //      algo além de 'S', pois o valor será sempre maiúsculo - código E10
        // while (resposta != "S" || resposta != "N"); 
        // Correto:
        } while (resposta != 'S');

        // Erros: 
        //  1- faltou o ponto e virgula ';' no final - código E1
        //  2- writeline está escrito de maneira errada, o correto é WriteLine - código E5 CS0117
        // Console.writeline("Programa encerrado.")
        // Correto:
        Console.WriteLine("Programa encerrado.");
    }
}