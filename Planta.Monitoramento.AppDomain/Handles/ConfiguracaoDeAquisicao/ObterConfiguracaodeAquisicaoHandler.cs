using MediatR;
using Planta.Monitoramento.AppDomain.Commands.ConfiguracaoAquisicao;

namespace Planta.Monitoramento.AppDomain.Handles.ConfiguracaoDeAquisicao
{
    public class ObterConfiguracaodeAquisicaoHandler : IRequestHandler<ObterConfiguracaoDeAquisicaoRequest, ObterConfiguracaoDeAquisicaoResponse>
    {
        public Task<ObterConfiguracaoDeAquisicaoResponse> Handle(ObterConfiguracaoDeAquisicaoRequest request, CancellationToken cancellationToken)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
