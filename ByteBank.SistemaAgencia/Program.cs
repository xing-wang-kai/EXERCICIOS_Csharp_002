using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListadeContasCorrentes lista = new ListadeContasCorrentes();

            lista.adicionar(new ContaCorrente(874, 5679787));
            lista.adicionar(new ContaCorrente(875, 5679788));
            lista.adicionar(new ContaCorrente(876, 5679789));

            

            
        }
    }
}
