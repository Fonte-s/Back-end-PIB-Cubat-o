using MediatR;
using Backend_PIB_Cubatao.Application.Commands.Requests;
using Backend_PIB_Cubatao.Domain.Interfaces;
using Backend_PIB_Cubatao.Application.Commands.Responses;

namespace Backend_PIB_Cubatao.Application.Handlers
{
  public interface ICriarUsuarioHandler
  {
    CreateUsuarioResponse Handle(CreateUsuarioRequest request);
  }
}