// somente declarando uma variavel do tipo inteira e sem valor
// int num1;

// console.WriteLine(num1);

//declarando uma variavel do tipo inteiro e atribuindo valor 5
// int num2= 5;

//declarando variavel string
// string nomeAçluno = 'paulo';

//variavel dso tipo logico (true ou false)
// bool resultado = true;


// variavel do tipo double valor com varias casas decimais
// double coorden = 1.38749303288

//variavel do tipo decimal - utilizada para valores 
// decimal valor = 1.80M;

int idade = 16;
string meuNome= "Guilherme Lima"; //valorTotalPedido
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("Em qual cidade voce nasceu?");
//readline serve apenas para que eu receba uma informação do usuario e armazena em um variavel
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Voce nasceu em {nomeCidade}");