using MediatR;
using Backend_PIB_Cubatao.Application.Commands.Responses; //atualizar o namespace correto 
using System.ComponentModel.DataAnnotations;

namespace Backend_PIB_Cubatao.Application.Commands.Requests
{
  public class CreateUsuarioRequest : IRequest<CreateUsuarioResponse>
  {
    [Required(ErrorMessage = "O campo Nome de usuário é obrigatório")]
    public string NomeUsuario { get; set; }
    [Required(ErrorMessage = "O campo Email é obrigatório")]
    public string Email { get; set; }
    [Required(ErrorMessage = "O campo Senha é obrigatório")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [Compare(nameof(Password), ErrorMessage = "A senha e a confirmação devem ser iguais")]
    public string ConfirmPassword { get; set; }
  }
}