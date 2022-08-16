using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscolarCypriano.Models
{
    public class Aluno
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de Nome Completo é obrigatório")]
        public string NomeCompleto { get; set; }
        public string Matricula { get; set; }
        public float NotaP1 { get; set; }
        public float NotaP2 { get; set; }
        public float NotaTrabalho { get; set; }

        public List<Materia> Materia { get; set; }



    }
}
