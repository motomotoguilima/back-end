Console.WriteLine("digite o valor de X:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("digite o valor de Y:");
int y = int.Parse(Console.ReadLine());

//exemplos de operadores aritmeticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //calculando o resto da divisao de x / 2
int restoDiv3 = y % 2; //calculando o resto da divisao de y / 2

//Console para exibir na tela as variaveis em cada linha 
//soma : 15
Console.WriteLine($"{x} + {y} = {soma}");
Console.WriteLine($"{x} - {y} = {subtracao}");
Console.WriteLine($"{x} * {y} = {multiplicacao}");
Console.WriteLine($"{x} / {y} = {divisao}");
Console.WriteLine($"{x} % {y} = {resto}");

if (restoDiv2 == 0)
{
    Console.WriteLine($"{x} e par");
}
else
{
    Console.WriteLine($"{x} e impar");
}
if (restoDiv3 == 1)
{
    Console.WriteLine($"{y} e impar");
}
else
{
    Console.WriteLine($"{y} e par");
}
//operação ternario
//condição ? se verdade : senao
string resultado = (restoDiv2 == 0) ? $"o numero {y} é par" : $"o numero {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 3;
//Aprendendo o switch case
switch (diaSemana)
{
    case 1:
        Console.WriteLine("hoje e domingo!");
        break;
    case 2:
        Console.WriteLine("hoje e segunda!");
        break;
    case 3:
        Console.WriteLine("hoje e terca!");
       break;
    case 4:
        Console.WriteLine("hoje e quarta!");
        break;
    case 5:
        Console.WriteLine("hoje e quinta!");
        break;
    case 6:
        Console.WriteLine("hoje e sexta!");
        break;
    case 7:
        Console.WriteLine("hoje e sabado!");
        break;
    default:
        Console.WriteLine("dia invalido");
        break;
}