using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required]        
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo titulo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O Campo Diretor é obrigatório")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O genero não pode ter mais que 30 caracter")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duracao deve ter no minimo 1 e no maximo 600")]
        public int Duracao { get; set; }

    }
}
