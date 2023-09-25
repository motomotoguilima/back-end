//o namespace é um nome em que usaremos para fazer referência quando usarmos em outra classe
namespace Sesi.Model
{
    //declarando nossa classe aluno
    public class Aluno
    {
        //declarando nosso atributos(propriedade) da classe
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        private int nrFaltas { get; set; }

        //criando um método
        public void Apresentar()
        {
            Console.WriteLine($"ola meu nome é {nome},eu tenho {idade} ano e estudo na turma do {turma}");
        }

        public void AdicionarFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }
        public void ResumirFaltas()
        {
            Console.WriteLine($" {nome} voce tem {nrFaltas} faltas");
        }

        public void JustificarFaltas(int nr){

            nrFaltas = nrFaltas - nr;
            Console.WriteLine($"eu estava doente e quero justificar as faltas {nrFaltas}");
        }
    }
}