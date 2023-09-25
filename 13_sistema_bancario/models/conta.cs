namespace Models
{
    public class ContaCorrente
    {
        private string titular { get; set; }
        private double saldo { get; set; }

        public ContaCorrente(string nomeTitular, double saldoPessoa)
        {
            this.titular = nomeTitular;
            this.saldo = saldoPessoa;
        }
        //metodo da classe pessoa
        public void consultarSaldo()
        {
            Console.WriteLine($"seu nome é {titular} e seu saldo disponível e de {saldo}");
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("realizar um saque da conta,com valor que voce deseja,");
            //Calcular o saldo junto com o valor
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            Console.WriteLine($"sacar o seu saldo disponivel na conta bancaria {saldo}");
            if (saldo >= valor)
            {
                Console.WriteLine("");
                saldo -= valor;
            }
            else{
                Console.WriteLine($"saldo insufuciente,voce tem 0 reais na sua conta");
            }
        }

    }
}
