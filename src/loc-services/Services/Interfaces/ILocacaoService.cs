using loc_data.Models;

namespace loc_services.Services.Interfaces
{
    public interface ILocacaoService
    {
        Locacao CreateLocacao(Locacao locacao);
        List<Locacao> GetLocacaoList();
    }
}
