using Backend_PIB_Cubatao.Application.Commands.Requests;
using Backend_PIB_Cubatao.Application.Commands.Responses;
using Backend_PIB_Cubatao.Application.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend_PIB_Cubatao.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ICriarUsuarioHandler _criarUsuarioHandler;
        public UsuarioController(ICriarUsuarioHandler criarUsuarioHandler)
        {
            _criarUsuarioHandler = criarUsuarioHandler;
        }
        [HttpPost]
        [Route("CriarUsuario")]
        public Task<CreateUsuarioResponse> Create([FromServices] IMediator mediator, [FromBody] CreateUsuarioRequest command)
        {
            var response = mediator.Send(command);
            return response;
        }
    }
}