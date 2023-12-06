using Planta.Monitoramento.AppDomain.Dto;

namespace Planta.Monitoramento.AppDomain.Commands.ConfiguracaoAquisicao
{
    public class ObterConfiguracaoDeAquisicaoResponse
    {
        public double PeriodoAquisicaoEmSegundos { get; set; }
        public int ValorUmidadeMaxima { get; set; }
        public int ValorUmidadeMinima { get; set; }
    }
}
