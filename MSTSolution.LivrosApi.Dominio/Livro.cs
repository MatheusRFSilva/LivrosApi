using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTSolution.LivrosApi.Dominio
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int Nr_Paginas { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Autor { get; set; }
    }
}
