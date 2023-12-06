using Planta.Monitoramento.AppDomain.Commands.ConfiguracaoAquisicao;
using Planta.Monitoramento.AppDomain.DbModels;
using Planta.Monitoramento.AppDomain.IServices;
using Planta.Monitoramento.Infra.Data;

namespace Planta.Monitoramento.Infra.Services
{
    public class ConfiguracaoDeAquisicaoService : IConfiguracaoDeAquisicaoService
    {
        private readonly ApplicationDbContext _contexto;

        public ConfiguracaoDeAquisicaoService(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public Task<ConfiguracaoDeAquisicao> ObterConfiguracaoDeAquisicao()
        {
            return Task.FromResult(_contexto.ConfiguracoesDeAquisicao.First());
        }


        //TODO
        public Task AtualizarConfiguracaoDeAquisicao(ObterConfiguracaoDeAquisicaoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
