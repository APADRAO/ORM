using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using ORM.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace ORM.src.Context
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=padronet;Username=postgres;Password=Br@zilUn1x!;");
            }
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pais> Paiss { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MenuAcesso> MenuAcessos { get; set; }
    }
}
