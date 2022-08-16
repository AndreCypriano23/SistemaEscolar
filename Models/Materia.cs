using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscolarCypriano.Models
{
    public class Materia
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de Nome da Matrícula é obrigatório")]
        public string Nome { get; set; }
        public List<Aluno> Aluno { get; set; }
        public List<Professor> Professor { get; set; }
    }
}
