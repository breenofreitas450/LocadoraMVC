using loc_data.Models;
using loc_data.Repositories.Interfaces;
using loc_services.Services.Interfaces;

namespace loc_services.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;
        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
        public Filme CreateLocacao(Filme locacao)
        {
            var validate = _filmeRepository.CreateFilme(locacao);
            if (validate == true)
                return locacao;
            else
            {
                return null;
            }
        }

        public List<Filme> GetLocacaoList()
        {
            return _filmeRepository.GetFilmeList();
        }
    }
}
