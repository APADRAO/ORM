using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.src.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<MenuAcesso>? MenuAcessos { get; set;}
    }
}
