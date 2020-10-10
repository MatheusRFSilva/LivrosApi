using MSTSolution.LivrosApi.AcessoDados.Entity.Context;
using MSTSolution.LivrosApi.Dominio;
using MSTSolution.Repositorios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTSolution.LivrosApi.Repositorios.Entity
{
    public class RepositorioLivros : RepositorioMSTSolution<Livro,int>
    {
        public RepositorioLivros(LivrosApiDbContext context)
            :base (context)
        {

        }
    }
}
