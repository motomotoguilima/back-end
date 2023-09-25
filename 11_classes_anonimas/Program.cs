//criando uma classe anonima
//var pessoa = new { nome = "joao", idade = 30 };
//Console.WriteLine($"nome : {pessoa.Nome}, idade: {pessoa.Idade}");
class Program
{
    public static void Main()
    {
        //criando uma classe anonima (classe sem definição inicial)
        var pessoa1 = new
        {
            nome = "lima",
            idade = 16
        };
        var pessoa2 = new
        {
            nome = "grazi",
            email = "grazi@aluno.senai.br"
        };


        //Console.WriteLine($"a pessoa é {pessoa1.nome} e tem {pessoa1.idade} anos");
        //Console.WriteLine($"a pessoa é {pessoa2.nome} e tem {pessoa2.idade} anos");
        Console.WriteLine(pessoa1.nome + pessoa1.idade);

        Console.WriteLine(pessoa2.nome + pessoa2.email);

        var carro1 = new
        {
            marca = "VW",
            modelo = "gol",
            ano = 2020
        };
        var carro2 = new
        {
            marca = "bmw",
            modelo = "x6",
            ano = 2023
        };
        var carro3 = new
        {
            marca = "ford",
            modelo = "mustang gt",
            ano = 2023
        };

        Console.WriteLine(carro1.marca + " " + carro1.modelo + " " + carro1.ano);
        Console.WriteLine(carro2.marca + " " + carro2.modelo + " " + carro2.ano);
        Console.WriteLine(carro3.marca + " " + carro3.modelo + " " + carro3.ano);

    }
}
