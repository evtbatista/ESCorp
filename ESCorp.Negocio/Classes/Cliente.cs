using System;
using System.Collections.Generic;
using ESCorp.Comum;
using ESCorp.Negocio.Classes;
using ESCorp.Negocio.Enumeradores;

namespace ESCorp.Negocio
{
    public class Cliente : EntidadeBase, ILog
    {
        #region Declarações

        public int IdCliente { get; private set; }

        private string _sobrenome;
        public string Sobrenome
        {
            // Quando queremos obter o valor do campo
            get
            {
                // Lógica qdo necessário
                return _sobrenome;
            }

            // Quando queremos atribuir um valor
            set { _sobrenome = value; }
        }

        // Propriedados auto implementadas qdo não houver necessidade de lógica
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Ddd { get; set; }
        public Telefone Telefone { get; set; }

        public string NomeCompleto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Nome))
                    return Sobrenome;
                if (string.IsNullOrWhiteSpace(Sobrenome))
                    return Nome;
                return Sobrenome + " , " + Nome;
            }
        }

        // Ao definir uma propriedade como static ela fica vinculada a sua própria classe e não ao objeto
        public static int QuantidadeInstancia { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public TipoCliente TipoCliente { get; set; }

        #endregion

        #region Construtores

        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }

        public Cliente(int idCliente, string sobrenome, string email):this() // this, encadeamento de construtores, dessa forma o construtor padrão será sempre chamado
        {
            IdCliente = idCliente; // this significa q está se referindo a instancia atual da classe Cliente.
            Sobrenome = sobrenome;
            Email = email;
        }

        #endregion

        #region Métodos
        public override bool Validar()
        {
            bool ehValido = !(string.IsNullOrWhiteSpace(Sobrenome) || string.IsNullOrWhiteSpace(Email));
    
            return ehValido;
        }

        public override string ToString()
        {
            return NomeCompleto;
        }

        public string Log()
        {
            var informacao = IdCliente + ": " +
                             NomeCompleto + " " +
                             "Email: " + Email + " " +
                             "Status: " + EstadoEntidade;

            return informacao;
        }

        #endregion

    }
}
