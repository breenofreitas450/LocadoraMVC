
using loc_data.Models;

namespace loc_data.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario GetUserLoginSenha(string login, string senha);
    }
}
