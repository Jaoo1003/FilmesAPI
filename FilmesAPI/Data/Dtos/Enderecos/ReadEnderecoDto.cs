using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Enderecos {
    public class ReadEnderecoDto {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O logradouro é um campo obrigatório")]
        public string Logradouro { get; set; }
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O número é obrigatório")]
        public int Numero { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
