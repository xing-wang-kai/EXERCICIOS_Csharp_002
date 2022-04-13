using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        /**
         puxo o method da biblioteca dentro da mesma biblioteca para autenticar a senha
        desta meneira consigo usar este metodo para facilitar a manutenção do mesmo
        */
        private AutenticacaoHelper _AutenticarHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _AutenticarHelper.CompararSennhas(Senha, senha);
        }
    }
}