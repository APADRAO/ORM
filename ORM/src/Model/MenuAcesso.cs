using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class MenuAcesso
    {
        [Key]
        public int id { get; set; }
        public required string nome { get; set; }
        public required string codigo { get; set; }
        public required string endereco { get; set; }   

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public required Role Role { get; set; }

    }
}
