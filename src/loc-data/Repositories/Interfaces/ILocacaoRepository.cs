using loc_data.Models;

namespace loc_data.Repositories.Interfaces
{
    public interface ILocacaoRepository
    {
        bool CreateLocacao(Locacao locacao);
        List<Locacao> GetLocacaoList();
    }
}
