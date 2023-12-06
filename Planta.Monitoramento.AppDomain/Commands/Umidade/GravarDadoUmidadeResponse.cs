using Planta.Monitoramento.AppDomain.Dto;

namespace Planta.Monitoramento.AppDomain.Commands.Umidade
{
    public class GravarDadoUmidadeResponse
    {
        public UmidadeDto DadoGravado { get; set; }
        public ConfiguracaoDeAquisicaoDto ConfiguracaoDeAquisicao { get; set; }
    }
}
