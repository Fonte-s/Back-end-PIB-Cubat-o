using Backend_PIB_Cubatao.Application.Commands.Requests;
using Backend_PIB_Cubatao.Application.Commands.Responses;
using Backend_PIB_Cubatao.Domain.Entities;
using Backend_PIB_Cubatao.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

public class CriarUsuarioHandler : IRequestHandler<CreateUsuarioRequest, CreateUsuarioResponse>
{
  private readonly IUsuarioRepository _usuarioRepository;
  public CriarUsuarioHandler(IUsuarioRepository usuarioRepository)
  {
    _usuarioRepository = usuarioRepository;
  }
  public async Task<CreateUsuarioResponse> Handle(CreateUsuarioRequest request, CancellationToken cancellationToken)
  {
    var user = new Usuario
    {
      UserName = request.NomeUsuario,
      Email = request.Email
    };
    var result = await _usuarioRepository.AddUsuario(user);
    return new CreateUsuarioResponse
    {
      DataCriacao = new DateTime(),
      Sucesso = result.Sucesso,
      Mensagem = result.Mensagem
    };
  }
}