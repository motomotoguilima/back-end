//sempre que formos utilizar bibliotecas ou classes ja criadas importamos ela com using
using Sesi.Model;
class Program
{
    public static void Main()
    {
        //criando uma variavel aluno1 e instanciando da classe aluno, ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "guilherme"; //se quiser que a pessoa digita o nome e so colocar Console.Readline();
        aluno1.idade = 16;
        aluno1.turma = "2º EM";
        //chamando o método da classe Alunos
        aluno1.Apresentar();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);


        //criando uma variavel aluno1 e instanciando da classe aluno, ou seja, estamos criando nosso objeto
        var aluno2 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
        aluno2.nome = "matheus"; //se quiser que a pessoa digita o nome e so colocar Console.Readline();
        aluno2.idade = 16;
        aluno2.turma = "2º EM";
        //chamando o método da classe Alunos
        aluno2.Apresentar();
    }
}