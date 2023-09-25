//colocamos o namespace dela 
using Models;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine($"bem vindo ao banco sesi ");
        Console.WriteLine("-------------------------");
        ;

        Menu();


    }
    public static void Menu()
    {
        //Criar objeto da Classe cContaCorrete
        Console.WriteLine($"digite o titular:");
        string nomeTitular = (Console.ReadLine());
        ContaCorrente ContaC = new ContaCorrente(nomeTitular, 0);

        string opcao = "0";

        do
        {
            Console.WriteLine(" MENU ");
            Console.WriteLine(" digite  1- para consultar o seu saldo");
            Console.WriteLine(" digite  2- para depositar o seu valor");
            Console.WriteLine(" digite  3- para sacar seu dinheiro");
            Console.WriteLine(" digite  0- para sair do sistema");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("obrigado,volte sempre!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    //objeto.método()
                    ContaC.consultarSaldo();
                    break;
                case "2":
                    //Receber o valor com ReadLine
                    //objeto.método(valorRecebido)
                    float valor = int.Parse(Console.ReadLine());
                    ContaC.Depositar(valor);
                    break;
                case "3":
                    float valorSacar = int.Parse(Console.ReadLine());
                    ContaC.Sacar(valorSacar);
                    break;
                default:
                    Console.WriteLine("opção invalida");
                    break;
            }

        } while (opcao != "0");
    }
}
