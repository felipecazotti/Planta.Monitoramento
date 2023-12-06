using Planta.Monitoramento.AppDomain.Commands.Umidade;

namespace Planta.Monitoramento.AppDomain.IServices
{
    public interface IUmidadeService
    {
        Task<GravarDadoUmidadeResponse> GravarDadoUmidade(GravarDadoUmidadeRequest request);
    }
}
