using System.ComponentModel.DataAnnotations;

namespace Planta.Monitoramento.Api.Models
{
    public class ConfiguracaoDeAquisicao
    {
        [Required(ErrorMessage = "Id do dispositivo é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Perido de aquisição é obrigatório")]
        public double PeriodoAquisicaoEmSegundos { get; set; }

        [Required(ErrorMessage = "ValorUmidadeMaxima é obrigatorio")]
        public int ValorUmidadeMaxima { get; set; }

        [Required(ErrorMessage = "ValorUmidadeMinima é obrigatório")]
        public int ValorUmidadeMinima { get; set; }
    }
}
