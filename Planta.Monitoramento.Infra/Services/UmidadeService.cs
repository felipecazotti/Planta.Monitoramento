using Mapster;
using Microsoft.EntityFrameworkCore;
using Planta.Monitoramento.AppDomain.Commands.Umidade;
using Planta.Monitoramento.AppDomain.DbModels;
using Planta.Monitoramento.AppDomain.Dto;
using Planta.Monitoramento.AppDomain.IServices;
using Planta.Monitoramento.Infra.Data;

namespace Planta.Monitoramento.Infra.Services
{
    public class UmidadeService : IUmidadeService
    {
        private readonly ApplicationDbContext _contexto;

        public UmidadeService(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<GravarDadoUmidadeResponse> GravarDadoUmidade(GravarDadoUmidadeRequest request)
        {
            var dadoUmidadeModel = request.Adapt<Umidade>();
            var taskRecuperaConfiguracaoAquisicao = _contexto.ConfiguracoesDeAquisicao.FirstAsync();
            var dadoUmidadeAdicionado = _contexto.DadosUmidade.Add(dadoUmidadeModel);
            var taskSalvaMudancasNoDb = _contexto.SaveChangesAsync();

            await Task.WhenAll(taskRecuperaConfiguracaoAquisicao, taskSalvaMudancasNoDb);

            return new GravarDadoUmidadeResponse
            {
                DadoGravado = dadoUmidadeAdicionado.Entity.Adapt<UmidadeDto>(),
                ConfiguracaoDeAquisicao = taskRecuperaConfiguracaoAquisicao.Result.Adapt<ConfiguracaoDeAquisicaoDto>()
            };
        }
    }
}
