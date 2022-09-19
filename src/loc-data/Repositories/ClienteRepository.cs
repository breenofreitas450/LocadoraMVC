using loc_data.Context;
using loc_data.Models;
using loc_data.Repositories.Interfaces;

namespace loc_data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Cliente> GetClienteList()
        {
            return _context.Cliente.ToList();
        }
        public bool CreateCliente(Cliente cliente)
        {
            try
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e) { return false; }
        }
    }
}
