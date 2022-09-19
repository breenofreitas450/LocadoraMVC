using loc_data.Models;
using loc_data.Repositories.Interfaces;
using loc_services.Services.Interfaces;

namespace loc_services.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Cliente CreateLocacao(Cliente cliente)
        {
            var validate = _clienteRepository.CreateCliente(cliente);
            if (validate == true)
                return cliente;
            else
            {
                return null;
            }
        }

        public List<Cliente> GetLocacaoList()
        {
            return _clienteRepository.GetClienteList();
        }
    }
}
