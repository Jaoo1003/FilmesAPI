using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos {
    public class UpdateFilmeDto {
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = ("O gênero deve ter no máximo 30 caracteres"))]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = ("A duração deve ter no mínimo 1 e no máximo 600 minutos"))]
        public int Duracao { get; set; }
    }
}
