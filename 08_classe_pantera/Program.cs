//sempre que formos utilizar bibliotecas ou classes ja criadas importamos ela com using
using Sesi.Model;
class Program
{
    public static void Main()
    {
        //criando uma variavel Pantera1 e instanciando da classe aluno, ou seja, estamos criando nosso objeto
        var pantera1 = new Pantera();

        
        pantera1.cor = "preta";
        pantera1.tamanho = "1,70" ;
        pantera1.peso = 60 ;
        pantera1.especie = "felinos";
        pantera1.alimentacao = "carnivora";
        pantera1.Apresentar();
        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();
    }
}