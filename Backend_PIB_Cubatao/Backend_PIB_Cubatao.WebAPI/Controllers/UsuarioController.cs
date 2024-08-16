using Backend_PIB_Cubatao.Application.Commands.Requests;
using Backend_PIB_Cubatao.Application.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_PIB_Cubatao.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        [HttpPost("CriarUsuario")]
        public async Task<CreateUsuarioResponse> Create([FromBody] CreateUsuarioRequest command)
        {
            return await _mediator.Send(command);
        }
    }
}