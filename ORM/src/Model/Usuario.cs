using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public required string password { get; set; }
        public string? email { get; set; }
        
        [ForeignKey("Endereco")]
        public int EnderecoId { get; set; }
        public required Endereco Endereco { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public required Role Role { get; set; }
    }
}
