//colocamos o namespace dela 
using Models;

public class Program
{
    //main tem que ser maiusculo - Main
    public static void Main()
    {
        //usando de forma public sem um metodo construtor
        // criando um objeto da classe pessoas
        //instanciando sem um metodo construtor
        //var ou o nome da nossa classe (ex: Pessoa)
        /*var pessoa1 = new Pessoa();
        pessoa1.nome = "Guilherme";
        pessoa1.idade= 16;
        pessoa1.Cantar();

        //alternativa para criação de um objeto sem construtor
        var pessoa2 = new Pessoa{
            nome = "mathus",
            idade = 35
        };
        pessoa2.Cantar();
        */
        
// usando de forma private com o metodo construtor
        Pessoa pessoa1 = new Pessoa("matus", 2024, "Matus.amorim5@aluno.senai.org.br");
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("jorgin", 2025, "jorgin.andre10@aluno.senai.org.br");
        pessoa2.Cantar();
        pessoa2.Informacoes();

         Pessoa pessoa3 = new Pessoa("lima", 2025, "lima.guizao5@aluno.senai.org.br");
        pessoa3.Cantar();
        pessoa3.Informacoes();
    }
}