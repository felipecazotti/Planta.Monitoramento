using System.ComponentModel.DataAnnotations;

namespace Planta.Monitoramento.Api.Models
{
    public class Umidade
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "TimeStamp é obrigatório ")]
        public DateTime TimesStamp { get; set; }

        [Required(ErrorMessage = "UmidadeRelativa é obrigatória")]
        [Range(0.0, 100.0, ErrorMessage = "Valor de UmidadeRelativa fora do limite de 0% a 100%")]
        public double UmidadeRelativa { get; set; }
    }
}
