using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioProjeto.Models;

namespace UsuarioProjeto.Contexto
{
    public class ProjetoUsuarioDbContext : DbContext
    {
        public ProjetoUsuarioDbContext(DbContextOptions<ProjetoUsuarioDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
