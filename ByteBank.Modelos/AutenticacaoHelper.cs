using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{   //esta class é internal ou seja ela não pode ser usada fora desta biblioteca, 
    //seu uso se limita somente a este projeto.
    internal class AutenticacaoHelper
    {
        public bool CompararSennhas(string SenhaVerdadeira, string SenhaTetativa)
        {
            return SenhaVerdadeira == SenhaTetativa;
        }
    }
}
