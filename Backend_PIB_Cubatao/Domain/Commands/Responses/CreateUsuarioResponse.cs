namespace Backend_PIB_Cubatao.Domain.Commands.Responses {
  public class CreateUsuarioResponse 
  {
    public Guid Id {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public DateTime DataCriacao {get; set;}
  }
}