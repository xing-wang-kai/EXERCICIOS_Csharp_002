using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
        }
        private AutenticacaoHelper _AutenticarHelper = new AutenticacaoHelper();
        public bool Autenticar(string senha)
        {
            return _AutenticarHelper.CompararSennhas(Senha, senha);
        }
    }
}
