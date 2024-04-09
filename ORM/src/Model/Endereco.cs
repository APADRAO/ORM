using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }

        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }
        public required Cidade Cidade { get; set; }
    }

}

