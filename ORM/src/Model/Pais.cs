using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        public required string codigo { get; set; }
        public required string nome { get; set; }

    }
}
