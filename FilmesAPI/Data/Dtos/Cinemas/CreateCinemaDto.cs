﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Cinemas {
    public class CreateCinemaDto {

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
    }
}
