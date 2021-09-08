using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2_Carlos_Daniel_Thiago_Formento.Model
{
    class Indices
    {
        public Indices(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public int linha { get; set; }
        public int coluna { get; set; }
    }
}
