using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int matricula { get; set; }

        public double salario { get; set; }
    }
}
