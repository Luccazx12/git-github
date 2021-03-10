﻿using System.ComponentModel.DataAnnotations.Schema;

namespace aspnetmvc.Models
{
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string Nome { get; set; }
        public int CursoID { get; set; }

        [ForeignKey("CursoID")]
        public virtual Curso Curso { get; set; }
    }
}