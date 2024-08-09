using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Backend_PIB_Cubatao.Controllers
{
  [ApiController]
  [Route("[controller]")]

  public class UsuarioController : ControllerBase
  {
    UsuarioController(CadastroUsuario cadastroUsuario, LoginUsuario loginUsuario)
    {

    }

  }


}