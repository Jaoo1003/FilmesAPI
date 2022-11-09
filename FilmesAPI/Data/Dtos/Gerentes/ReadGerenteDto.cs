using FilmesAPI.Models;

namespace FilmesAPI.Data.Dtos.Gerentes {
    public class ReadGerenteDto {

        public int Id { get; set; }
        public string Name { get; set; }
        public object Cinemas { get; set; }
    } 
}
