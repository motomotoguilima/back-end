class jogo
{
    public static void Main()
    {
        Console.WriteLine("digite um numero");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"o dobro do numero é {Dobro(n1)} e metade dele é {Metade(n1)}");
        Tabuada(int.Parse(Console.ReadLine()));
        SomaComDoWhile();
    }
    public static int Metade(int n1)
    {
        int metade = n1 / 2;
        return metade;
    }
    public static int Dobro(int n1)
    {
        int dobro = n1 * 2;
        return dobro;
    }
    public static void Tabuada(int n)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"{contador} execução {n} X {contador} = {n * contador}");
            contador++;
        }
    }
    public static void SomaComDoWhile()
    {

        int soma = 0;
        int menor = 10000;
        int maior = 0;
        int num = 0;
        do
        {
            Console.WriteLine("digite a soma:");
            num = int.Parse(Console.ReadLine());
            
            if(num > 0)
                soma = soma + num;
            if (num > maior)
            {
                maior = num;
            }
            if (num < menor && num > 0)
            {
                menor = num;
            }

        } while (num > 0);
Console.WriteLine($"a soma é {soma} e o {maior} e {menor} ");


    }

}
