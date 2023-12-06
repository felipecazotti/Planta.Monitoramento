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

        public async Task<GravarDadoUmidadeResponse> GravarDadoUmidadeAsync(GravarDadoUmidadeRequest request)
        {
            var dadoUmidadeModel = request.Adapt<Umidade>();
            var configuracaoAquisicao = await _contexto.ConfiguracoesDeAquisicao.FirstAsync();
            await _contexto.DadosUmidade.AddAsync(dadoUmidadeModel);
            await _contexto.SaveChangesAsync();

            return new GravarDadoUmidadeResponse
            {
                DadoGravado = dadoUmidadeModel.Adapt<UmidadeDto>(),
                ConfiguracaoDeAquisicao = configuracaoAquisicao.Adapt<ConfiguracaoDeAquisicaoDto>()
            };

        }
    }
}
