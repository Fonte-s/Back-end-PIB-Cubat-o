using Backend_PIB_Cubatao.Domain.Entities;
namespace Backend_PIB_Cubatao.Domain.Interfaces
{
  public interface IUsuarioRepository
  {
    Task<IEnumerable<Usuario>> GetAllUsuarios();
    Task<Usuario?> GetUsuarioById(int usuarioId);
    Task<Usuario?> AddUsuario(Usuario usuario);
    Task<Usuario?> UpdateUsuario(Usuario usuario);
    Task<Usuario?> DeleteUsuario(int usuarioId);
  }
}