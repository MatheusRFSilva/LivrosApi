using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MSTSolution.Comum.Interfaces
{
    public interface IRepositorioMSTSolution<TDominio,TChave>
        where TDominio : class
    {
        List<TDominio> Selecionar(Expression<Func<TDominio, bool>> where = null);

        TDominio SelecionarPorId(TChave id);

        void Inserir(TDominio dominio);
        void Atualziar(TDominio dominio);
        void Excluir(TDominio dominio);
        void ExcluirPorId(TChave id);
    }
}
