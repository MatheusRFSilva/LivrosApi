using MSTSolution.LivrosApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTSolution.LivrosApi.AcessoDados.Entity.Context
{
    public class LivrosApiDbContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public LivrosApiDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
