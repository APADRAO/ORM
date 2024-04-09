using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class Uf
    {
        [Key] public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Codigo { get; set; }
        public required string cd { get; set; }
    }
}
