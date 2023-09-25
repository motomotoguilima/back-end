//funcao do javascript
//function nomeFuncao (nome){}

//funcao do C#
//public static string nomeFuncao(string nome){}

class Sesi
{
    public static void Main()
    {
        //chamando metodos sem retorno
        Mostrarmensagem("ola amigos,sejam bv's");
        ImprimirDataHora();
        //chamando o metodo pontenciacao com o parâmetro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {potencia}");

        ContagemRegressiva(10);
        JogoQueNrSouEu();
    
    }
    //metodo com parametro e com retorno
    public static double Potenciacao(int num)
    {
        double resultado = Math.Pow(num, 2);
        return resultado;
    }

    //metodo sem parametro e sem retorno
    public static void ImprimirDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());

    }
    //metodo com parametro e sem retorno
    public static void Mostrarmensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(500); // são 500 ms segundos
        }
        Console.WriteLine("BOOOOOOOOOOM");
    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("*********************************************");
        Console.WriteLine("                 bem vindo ao jogo        ");
        Console.WriteLine("sorteei um nº de 1 a 20,tente adivinha-lo");
        Console.WriteLine("**********************************************");
        Console.WriteLine("");
        
        Random rnd = new Random();
        int nrSorteado= rnd.Next(20);
        int nrDigitado = -1;


        do{
            Console.WriteLine("digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O numero digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
            Console.WriteLine("o  numero digitado é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);
        Console.WriteLine("parabens voce acertou");
    }

}

