using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "Informe um título")]
    [StringLength(100, ErrorMessage = "Título muito grande")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Informe um gênero")]
    [StringLength(50, ErrorMessage = "Gênero muito grande")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 300, ErrorMessage = "O filme deve ter entre 70 e 300 minutos")]
    public int Duracao { get; set; }
}
