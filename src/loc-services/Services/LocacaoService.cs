using loc_data.Models;
using loc_data.Repositories.Interfaces;
using loc_services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loc_services.Services
{
    public class LocacaoService : ILocacaoService
    {
        private readonly ILocacaoRepository _locacaoRepository;
        public LocacaoService(ILocacaoRepository locacaoRepository)
        {
            _locacaoRepository = locacaoRepository;
        }
        public Locacao CreateLocacao(Locacao locacao)
        {
            var validate = _locacaoRepository.CreateLocacao(locacao);
            if(validate == true)
                return locacao;
            else
            {
                return null;
            }
        }

        public List<Locacao> GetLocacaoList()
        {
            return _locacaoRepository.GetLocacaoList();
        }
    }
}
