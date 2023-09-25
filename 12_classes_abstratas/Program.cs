//classe que sera herdada pelo filho - superclass
 abstract class Animal

{
    public string cor { get; set; }

    public void EmitirSom()
    {
        Console.WriteLine("animal emitindo som");
    }

}

//class filha,que herdara da classe animal
//recebera todos os atributos e metodos da superClasse
class Cachorro : Animal
{
    public string tipoPelo { get; set; }
    public void Latir()
    {
        Console.WriteLine($"o cachorro {cor} está latindo");
    }
}

//class filha,que herdara da classe animal
//recebera todos os atributos e metodos da superClasse
class Gato : Animal
{
    public void Miar()
    {
        Console.WriteLine($"o gato {cor} está miando");

    }
}



class Program
{
    static void Main()


    {

        //nao e permitido instanciar um objeto de uma classe abstrata
        //animal ou var
        //Animal animalGenerico = new Animal();
        //animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.cor = "branco";
        meuGato.EmitirSom();
        meuGato.Miar();
    }
}