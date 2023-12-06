using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planta.Monitoramento.AppDomain.Commands.Umidade;

namespace Planta.Monitoramento.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UmidadeController : ControllerBase
    {
        private IMediator _mediator { get; set; }

        public UmidadeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("GravarDadoUmidade")]
        [ProducesDefaultResponseType(typeof(GravarDadoUmidadeResponse))]
        public async Task<IActionResult> GravarDadoUmidade([FromBody] GravarDadoUmidadeRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
