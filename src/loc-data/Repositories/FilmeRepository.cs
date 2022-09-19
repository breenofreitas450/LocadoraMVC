using loc_data.Context;
using loc_data.Models;
using loc_data.Repositories.Interfaces;

namespace loc_data.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly AppDbContext _context;
        public FilmeRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Filme> GetFilmeList()
        {
            return _context.Filme.ToList();
        }
        public bool CreateFilme(Filme filme)
        {
            try
            {
                _context.Filme.Add(filme);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e) { return false; }
        }

    }
}
