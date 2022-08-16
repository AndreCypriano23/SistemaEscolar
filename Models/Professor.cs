using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscolarCypriano.Models
{
    public class Professor
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de Nome do Professor é obrigatório")]
        public string Nome { get; set; }
        public List<Materia> Materia { get; set; }
    }
}
