using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domains
{
    public class Genero
    {
        [Key]
        public Guid IdGenero { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Nome do gênero é obrigatório!")]
        public string? Nome { get; set; }

        public static implicit operator Genero(Filme v)
        {
            throw new NotImplementedException();
        }
    }
}
