using System.ComponentModel.DataAnnotations;

namespace Taskfy.Api.Models
{
    public class TarefaDto
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descricao { get; set; }

    }
}
