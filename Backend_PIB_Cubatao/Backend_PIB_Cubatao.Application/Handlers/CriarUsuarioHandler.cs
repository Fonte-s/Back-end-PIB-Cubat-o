using Backend_PIB_Cubatao.Application.Commands.Requests;
using Backend_PIB_Cubatao.Application.Commands.Responses;
using Backend_PIB_Cubatao.Domain.Entities;
using Backend_PIB_Cubatao.Domain.Interfaces;
using MediatR;

namespace Backend_PIB_Cubatao.Application.Handlers
{
  public class CriarUsuarioHandler : IRequestHandler<CreateUsuarioRequest, CreateUsuarioResponse>
  {
    private readonly IUsuarioRepository _usuarioRepository;
    public CriarUsuarioHandler(IUsuarioRepository usuarioRepository)
    {
      _usuarioRepository = usuarioRepository;
    }
    public async Task<CreateUsuarioResponse> Handle(CreateUsuarioRequest request, CancellationToken cancellationToken)
    {
      var result = new CreateUsuarioResponse
      {
        DataCriacao = new DateTime(),
        Sucesso = false
      };
      var user = new Usuario
      {
        UserName = request.NomeUsuario,
        Email = request.Email
      };
      var usuario = await _usuarioRepository.AddUsuario(user);
      if (usuario is null)
      {
        result.Sucesso = false;
        result.Mensagem = "Falha ao cadastrar usuário";
        return result;
      }

      result.Sucesso = true;
      result.Mensagem = "Sucesso ao cadastrar usuário";
      return result;
    }
  }
}