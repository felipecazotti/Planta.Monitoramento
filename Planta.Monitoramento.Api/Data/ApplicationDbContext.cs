using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Planta.Monitoramento.Api.Models;

namespace Planta.Monitoramento.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Umidade> DadosUmidade { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
