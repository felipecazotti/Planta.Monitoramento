using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planta.Monitoramento.AppDomain.Commands.ConfiguracaoAquisicao;

namespace Planta.Monitoramento.Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ConfiguracaoDeAquisicaoController : ControllerBase
    {
        private IMediator _mediator { get; set; }

        public ConfiguracaoDeAquisicaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("ConfiguracaoDeAquisicao")]
        [ProducesDefaultResponseType(typeof(ObterConfiguracaoDeAquisicaoResponse))]
        public IActionResult ObterConfiguracaDeAquisicao()
        {
            var response = _mediator.Send(new ObterConfiguracaoDeAquisicaoRequest());
            return Ok(response);
        }
    }
}
