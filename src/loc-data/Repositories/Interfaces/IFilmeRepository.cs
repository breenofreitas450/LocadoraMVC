
using loc_data.Models;

namespace loc_data.Repositories.Interfaces
{
    public interface IFilmeRepository
    {
        bool CreateFilme(Filme filme);
        List<Filme> GetFilmeList();
    }
}
