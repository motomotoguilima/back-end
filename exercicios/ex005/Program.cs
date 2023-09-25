
class Churras
{
    public static void Main()
    {
        ListaDeChurrasco();
//chamar outro metodo
         SonhosDeConsumo();
}

    public static void ListaDeChurrasco()
    {
        //declarar o vetor com 6 posiçoes tipo string
        string[] churras = new string[6];

        //receber os produtos que precisam ser comprados
        for (int i = 0; i <= 6; i++)
        {
            //console para informar o produto a comprar
            Console.WriteLine("Digite os ingredientes que vc quer p churras:");
            //declarar uma  variavel produto para receber o que eu escrever no ReadLine
            string produto = Console.ReadLine();
            //atribuir no meu vetor o produto que eu digitei pela posição
            churras[i] = produto;
        }
        //ordenar meu vetor
        Array.Sort(churras);
        //para cada item na lista imprimir o produto
        foreach (string intem in churras)
        {
            Console.WriteLine(item);
        }
    }
    public static void SonhosDeConsumo()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;

        for (int i = 0; i < 3; i++) ;
        {
            Console.WriteLine($"digite teu sonho {i}");
            string sonho = Console.ReadLine();
            Console.WriteLine($"digite teu valor {i}");
            decimal valor = decimal.Parse(Console.WriteLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }


        foreach (decimal val in valores)
        {
            total = total + val;
        }
        Console.WriteLine($"seus sonhos custarão aprox. R${total}");

    }
}

