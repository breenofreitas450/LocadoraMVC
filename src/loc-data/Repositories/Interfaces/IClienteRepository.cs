using loc_data.Models;
namespace loc_data.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        bool CreateCliente(Cliente filme);
        List<Cliente> GetClienteList();
    }
}
