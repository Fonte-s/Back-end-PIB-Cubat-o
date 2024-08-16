using Backend_PIB_Cubatao.Infrastructure.Context;
using Backend_PIB_Cubatao.Domain.Interfaces;
using Backend_PIB_Cubatao.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Backend_PIB_Cubatao.Infrastructure.Repositories
{
  public class UsuarioRepository : IUsuarioRepository
  {
    private readonly AppDbContext _context;
    private readonly UserManager<Usuario> _userManager;
    public UsuarioRepository(AppDbContext context, UserManager<Usuario> userManager)
    {
      _context = context;
      _userManager = userManager;
    }
    public async Task<Usuario?> AddUsuario(Usuario usuario)
    {
      if (usuario == null)
      {
        throw new ArgumentException("Usuário não existe");
      }

      var result = await _userManager.CreateAsync(usuario, usuario.PasswordHash);

      if (!result.Succeeded)
      {
        throw new ApplicationException("Falha ao adicionar usuário" + string.Join(", ", result.Errors.Select(e => e.Description)));
      }

      return usuario;
    }

    public async Task<IEnumerable<Usuario>> GetAllUsuarios()
    {
      return await Task.FromResult(_userManager.Users.ToList());
    }

    public async Task<Usuario?> GetUsuarioById(int usuarioId)
    {
      var usuario = await _userManager.Users.FirstOrDefaultAsync(user => user.Id == usuarioId.ToString()) ?? throw new ArgumentException("Usuário não encontrado");
      return usuario;
    }

    public async Task<Usuario?> UpdateUsuario(Usuario usuario)
    {
      if (usuario == null)
      {
        throw new Exception("Usuário não encontrado");
      }
      var result = await _userManager.UpdateAsync(usuario);
      if (!result.Succeeded)
      {
        throw new ArgumentException("Falha ao atualizar o usuário");
      }
      return usuario;
    }

    public async Task<Usuario> DeleteUsuario(int usuarioId)
    {
      var usuario = await _userManager.Users.FirstOrDefaultAsync(user => user.Id == usuarioId.ToString()) ?? throw new Exception("Não foi possível encontrar o usuário para deleção");
      var result = await _userManager.DeleteAsync(usuario);
      if (!result.Succeeded)
      {
        throw new Exception("Falha ao deletar usuário");
      }
      return usuario;
    }
  }
}