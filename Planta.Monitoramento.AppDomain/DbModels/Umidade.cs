using System.ComponentModel.DataAnnotations;

namespace Planta.Monitoramento.AppDomain.DbModels
{
    public class Umidade
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "TimeStamp é obrigatório ")]
        public DateTime TimeStamp { get; set; }

        [Required(ErrorMessage = "UmidadeRelativa é obrigatória")]
        [Range(0.0, 100.0, ErrorMessage = "Valor de UmidadeRelativa fora do limite de 0% a 100%")]
        public double UmidadeRelativa { get; set; }
    }
}
