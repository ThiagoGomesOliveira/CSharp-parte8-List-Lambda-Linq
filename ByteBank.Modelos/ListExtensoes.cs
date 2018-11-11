using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ByteBank.Modelos
{
  public static class ListExtensoes
    {
        public static void AdcionarVarios(this List<int> listaDeInteiros, params int[] itens)
        {
            foreach (int item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}