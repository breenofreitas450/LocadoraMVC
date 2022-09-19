using loc_data.Models;

namespace loc_services.Services.Interfaces
{
    public interface IClienteService
    {
        Cliente CreateLocacao(Cliente locacao);
        List<Cliente> GetLocacaoList();
    }
}
