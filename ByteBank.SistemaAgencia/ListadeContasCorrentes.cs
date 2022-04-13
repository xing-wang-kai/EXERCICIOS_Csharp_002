﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListadeContasCorrentes
    {
        private ContaCorrente[] _items;
        private int _proxpos;
        public ListadeContasCorrentes(int argsOpcional = 5)
        {
            _items = new ContaCorrente[argsOpcional];
            _proxpos = 0;
        }
        public void adicionar(ContaCorrente item)
        {
            verificarCapacidade(_proxpos+1);
            _items[_proxpos] = item;
            _proxpos++;
        }
        public void remover( ContaCorrente item)
        {

        }
        private void verificarCapacidade(int tamanho)
        {
            if (_items.Length >= tamanho)
            {
                return;
            }
            ContaCorrente[] novoArray = new ContaCorrente[tamanho*2];
            for(int i = 0; i < _items.Length; i++)
            {
                novoArray[i] = _items[i];
            }
            _items = novoArray; 
        }
    }
}
