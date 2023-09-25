using System.IO;

public class Program
{
    public static void Main()
    {
        //chamando o metodo gravar arquivo
        //GravarArquivo();
        //chamando o metodo lerarquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {
      
        try
        {
            string arquivoTxT = "Arquivo/arquivo.txt";
             //verificar se o arquivo existe
       if (File.Exists(arquivoTxT) == false) {
        //criando um arquivo.txt, este comando é executado quando a verificação no if e false ou seja arquivo nao existe
        File.Create(arquivoTxT);
       }

            //instanciando um objeto da classe streamreader para ler o arquivo
            using (StreamReader arquivo = new StreamReader(arquivoTxT))
            {

                string linha;
                //fazendo while para linha por linha que contem no arquivo.txt
                while ((linha = arquivo.ReadLine()) != null)
                {
                    //escrevendo no console o conteudo da linha
                    Console.WriteLine(linha);

                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"ocorreu um erro ao gravar o arquivo ; {erro.Message}");
        }
    }

    //public static void GravarArquivo()
 //{
        //try
        //{
            //using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            //{
               // Console.WriteLine("digite seu texto");
                //arquivo.WriteLine(Console.ReadLine());
                //arquivo.WriteLine("eu amo muito a graziela lozano dourado de matos, que tem 15 anos é faz aniversario em 05/11,meu amor todinho.");

            //}
        //}
        //catch (Exception erro)
        //{
           // Console.WriteLine($"ocorreu um erro ao gravar o arquivo ; {erro.Message}");
        //}
    //}
}
