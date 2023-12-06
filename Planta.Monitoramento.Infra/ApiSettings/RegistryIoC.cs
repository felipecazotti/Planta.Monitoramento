using Microsoft.Extensions.DependencyInjection;
using Planta.Monitoramento.AppDomain.IServices;
using Planta.Monitoramento.Infra.Services;

namespace Planta.Monitoramento.Infra.ApiSettings
{
    public static class RegistryIoC
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            #region SERVICES
            services.AddScoped<IUmidadeService, UmidadeService>();
            services.AddScoped<IConfiguracaoDeAquisicaoService, ConfiguracaoDeAquisicaoService>();
            #endregion
        }
    }
}
