Console.WriteLine("nome do aluno:");
string nomeAluno= Console.ReadLine();

Console.WriteLine("digite nota 1:");
int nt1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite nota 2:");
int nt2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite nota 3:");
int nt3 = int.Parse(Console.ReadLine());


int media = (nt1 + nt2 + nt3) / 3;
//if (media >= 7){
    //Console.WriteLine($" aluno {nomeAluno} foi aprovado ");
//}else {
    //Console.WriteLine($" aluno {nomeAluno} foi reprovado");}

string resultado = (media >= 7) ? $"o aluno {nomeAluno} passou" : $"o aluno {nomeAluno} reprovou";
Console.WriteLine(resultado);