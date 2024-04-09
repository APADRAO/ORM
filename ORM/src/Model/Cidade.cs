using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        public required string nome { get; set; }
        public required string codigo { get; set; }
        [ForeignKey("Uf")]
        public int UfId { get; set; }
        public required Uf Uf { get; set; }
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public required Pais Pais { get; set; }

    }
}
