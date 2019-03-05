using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
