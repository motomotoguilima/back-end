namespace Models
{
    public class Pessoa
    {
        //atributos da nossa classe pessoas
        //para montar isso e so usar prop
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private int anoNascimento { get; set; }
        /*      public string nome { get; set; }
                public int idade { get; set; }
                public string email { get; set; }
                public int anoNascimento { get; set; }
        */

        public string TodasInformacoes { get; set; }
        //nomePessoa e idadePessoa sao variaveis,nome que eu quiser colocar
        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            //this - atribuir o nome que eu colocar
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idade;

        }


        //metodo da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} esta cantando e ele tem {idade} anos, email informado {email} e meu ano de nascimento foi {anoNascimento}");
        }
        public void Informacoes()
        {
            Console.WriteLine($" exibir todas as informações nome {nome}, idade {idade}, email {email}, ano que nasceu{anoNascimento}");
        }

    }
}