using MediatR;
using Planta.Monitoramento.AppDomain.Commands.Umidade;
using Planta.Monitoramento.AppDomain.IServices;

namespace Planta.Monitoramento.AppDomain.Handles.Umidade
{
    public class GravarDadoUmidadeHandler : IRequestHandler<GravarDadoUmidadeRequest, GravarDadoUmidadeResponse>
    {
        public IUmidadeService _umidadeService { get; set; }

        public GravarDadoUmidadeHandler(IUmidadeService umidadeService)
        {
            _umidadeService = umidadeService;
        }

        public async Task<GravarDadoUmidadeResponse> Handle(GravarDadoUmidadeRequest request, CancellationToken cancellationToken)
        {
            var response = await _umidadeService.GravarDadoUmidadeAsync(request);
            return response;
        }
    }
}
