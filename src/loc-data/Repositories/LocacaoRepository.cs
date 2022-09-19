using loc_data.Context;
using loc_data.Models;
using loc_data.Repositories.Interfaces;

namespace loc_data.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly AppDbContext _context;
        public LocacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Locacao> GetLocacaoList()
        {
            return _context.Locacao.ToList();
        } 

        public bool CreateLocacao(Locacao locacao)
        {
            try
            {
                _context.Locacao.Add(locacao);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e) { return false; }
        }
    }
}
