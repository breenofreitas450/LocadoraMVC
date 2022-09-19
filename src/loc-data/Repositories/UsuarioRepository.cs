using loc_data.Context;
using loc_data.Models;
using loc_data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loc_data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }
        public Usuario GetUserLoginSenha(string login, string senha)
        {
            return _context.Usuario.FirstOrDefault(x => x.Login == login && x.Senha == senha);
        }
    }
}
