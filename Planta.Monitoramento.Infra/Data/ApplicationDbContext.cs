using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Planta.Monitoramento.AppDomain.DbModels;

namespace Planta.Monitoramento.Infra.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Umidade> DadosUmidade { get; set; }
        public DbSet<ConfiguracaoDeAquisicao> ConfiguracoesDeAquisicao { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
