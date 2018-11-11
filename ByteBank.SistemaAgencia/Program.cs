using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(10);
            idades.Add(30);
            idades.Add(29);
            

            Console.WriteLine();
            Console.ReadLine();
        }
        public static void TestarLista()
        {
            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));

        }
        public static void TestarIndexadores()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(100, 40010));
            lista.Adicionar(new ContaCorrente(101, 40011));
            lista.Adicionar(new ContaCorrente(102, 40012));
            lista.Adicionar(new ContaCorrente(103, 40013));

            //ContaCorrente conta = lista.GetItemNoIndice(2);
            //Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            lista.AdicionarVarios(
                           new ContaCorrente(100, 40010),
                           new ContaCorrente(101, 40011)
                                 );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente conta = lista[i];
                Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            }

        }
        public static void TestarAdcionar()
        {
            ContaCorrente contaThiago = new ContaCorrente(11111, 11111);
            ListaDeContaCorrente listaContaCorrente = new ListaDeContaCorrente();
            listaContaCorrente.Adicionar(new ContaCorrente(666, 222));
            listaContaCorrente.Adicionar(new ContaCorrente(667, 223));
            listaContaCorrente.Adicionar(contaThiago);
            listaContaCorrente.Remover(contaThiago);
        }
        public static void Somar()
        {
            int[] idades = new int[5] { 15, 28, 30, 50, 45 };

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                acumulador += idades[i];
            }
            int media = acumulador / idades.Length;
        }
    }
}
