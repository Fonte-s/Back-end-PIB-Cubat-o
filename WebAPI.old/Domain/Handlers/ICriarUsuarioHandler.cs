using MediatR;
using Backend_PIB_Cubatao.Domain.Commands.Responses;
using System.ComponentModel.DataAnnotations;
using Backend_PIB_Cubatao.Domain.Commands.Requests;

namespace Backend_PIB_Cubatao.Domain.Handlers 
{
  public interface ICriarUsuarioHandler : IRequestHandler<CreateUsuarioRequest, CreateUsuarioResponse> 
  { 
  }
}