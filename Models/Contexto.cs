using Microsoft.EntityFrameworkCore;

namespace SneakersProjetoFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Categoria>? Categoria { get; set; }
        public DbSet<CadastroProduto> CadastroProduto { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }

    }
}
