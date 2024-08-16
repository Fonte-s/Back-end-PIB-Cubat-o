using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Backend_PIB_Cubatao_old
{
  [Table("Usuário")]
  public class Usuario : IdentityUser
  {
    [Required]
    public string Nome {get; set;}
    [Required]
    public string Tipo {get; set;}
  }
}