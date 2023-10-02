using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DataAnnotation de como sera criado o nome da tabela no  BD
    [Table("Jogos")]
    public class Jogo
    {
        [Key]   //falando para o DB que este atribuindo sera uma chave
        public int JogoId { get; set; }
        [Required(ErrorMessage="nome é obrigatorio")]
        [MaxLength(200, ErrorMessage = "descrição pode exceder {1} caracteres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
    }
}