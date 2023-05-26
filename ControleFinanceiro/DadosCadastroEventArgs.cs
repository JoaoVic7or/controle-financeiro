using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    public class DadosCadastroEventArgs : EventArgs
    {
        public string Tipo { get; }
        public string Nome { get; }
        public string Valor { get; }

        public DadosCadastroEventArgs(string tipo, string nome, string valor)
        {
            Tipo = tipo;
            Nome = nome;
            Valor = valor;
        }
    }
}
