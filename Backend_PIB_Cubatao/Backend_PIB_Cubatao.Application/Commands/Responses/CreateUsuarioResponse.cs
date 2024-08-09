using System.ComponentModel.DataAnnotations;

namespace Backend_PIB_Cubatao.Application.Commands.Responses
{
  public class CreateUsuarioResponse
  {
    public DateTime DataCriacao { get; set; }
    public bool Sucesso { get; set; }
    public string Mensagem { get; set; }
  }
}