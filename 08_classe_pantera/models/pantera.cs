//o namespace é um nome em que usaremos para fazer referência quando usarmos em outra classe
namespace Sesi.Model
{
    //declarando nossa classe aluno
    public class Pantera
    {
        //declarando nosso atributos(propriedade) da classe
        public string tamanho { get; set; }
        public int peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }



        //criando um método
        public void Apresentar()
        {
            Console.WriteLine($"ola meu tamanho e {tamanho},eu tenho {peso} kg e sou da cor {cor} sou da {especie} e me alimento de {alimentacao}");
        }
        public void Correr()
        {
            Console.WriteLine($"a pantera esta correndo atras da sua presa");
        }
        public void Cacar()
        {
            Console.WriteLine($"a pantera esta cacando sua presa");
        }
        public void Reproduzir()
        {
            Console.WriteLine($"a pantera vai ter filhotes");
        }
    }
}
