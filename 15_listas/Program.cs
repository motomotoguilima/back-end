using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();
        //adicionando elementos à lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(100); //posição [1
        listaNumeros.Add(1000); //posição [2]

        //acessandos os dados pelas listas pelo indice,quando estamos acessando esse indice mudamos o [0] para a primeria posição [1]
        Console.WriteLine(listaNumeros[2]);


        //contagem de elementos
        listaNumeros.Add(55); // posição [3]
        Console.WriteLine($"neste momento temos {listaNumeros.Count} elementos");


        //criando uma lista de string
        List<string> listaNomes = new List<string>();
        //adicionando elementos à lista
        listaNomes.Add("julio"); //posição [0]
        listaNomes.Add("felipe"); //posição [1
        listaNomes.Add("lima"); //posição [2]

        //acessandos os dados pelas listas pelo indice,quando estamos acessando esse indice mudamos o [0] para a primeria posição [1]
        Console.WriteLine(listaNomes[2]);


        //contagem de elementos
        listaNomes.Add("douglao"); // posição [3]
        Console.WriteLine($"neste momento temos {listaNomes.Count} nomes");
        foreach (string nome in listaNomes)
        {
            Console.WriteLine(nome);
        }


        //lista com foreach
        //criando uma lista de nuemros ja atribuindo valores
        List<int> numeros = new List<int> { 1, 3, 5, 6, 7, 8, 9 };
        Console.WriteLine($"quantidade de elementos na lista numeros : {numeros.Count}");
        numeros.Remove(2); //remover o elemento do indice  2
        numeros.RemoveAt(1); //remover o elemento do indice  1
        numeros.RemoveRange(2, 2); //remover 2 elementos a partir do indice 2

        //substituindo a informação do item da lista
        numeros[0] = 100;

        //Iterando sobre todos os itens da lista
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }


        //criando uma lista com obejetos com minha classe aluno
        List<Aluno> ListaAlunos = new List<Aluno>();

        //adicionando um novo aluno a minha lista

        Aluno novoAluno = new Aluno("pedro", 16);
        ListaAlunos.Add(novoAluno);

        ListaAlunos.Add(new Aluno("patricia", 17));
        ListaAlunos.Add(new Aluno("jander", 17));
        ListaAlunos.Add(new Aluno("fernanda", 17));

        //exibindo a lista de alunos
        Console.WriteLine("lista de alunos");
        foreach (Aluno item in ListaAlunos)
        {
            Console.WriteLine(($"{item.nome}.{item.idade}"));

        }

        //criando uma nova lista ordenada por nome
        //LINQ utilizando sintaxe de consulta
        var ordenacao = from aluno in ListaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }
        //LINQ utilizando sintaxe de método
        var consulta = ListaAlunos
        .Where(aluno => aluno.idade == 17)
        .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
    }


}
