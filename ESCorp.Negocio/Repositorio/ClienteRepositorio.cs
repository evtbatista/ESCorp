using System;
using System.Collections.Generic;
using System.Linq;
using ESCorp.Negocio.Repositorio;

namespace ESCorp.Negocio
{
    public class ClienteRepositorio
    {
        private EnderecoRepositorio _enderecoRepositorio;

        public ClienteRepositorio()
        {
            _enderecoRepositorio = new EnderecoRepositorio();
        }

        public Cliente Obter(int idCliente)
        {
            // lógica para obter cliente específico

            var cliente = new Cliente(idCliente, "Wayne", "wayne@batman.com");
            cliente.Nome = "Bruce";
            cliente.DataNascimento = new DateTime(1980,2,6);
            cliente.Telefone = new Telefone("11", "123445678");
            cliente.Enderecos = _enderecoRepositorio.ObterPeloIdCliente(idCliente).ToList();

            return cliente;
        }

        public List<Cliente> Obter()
        {
            return new List<Cliente>();
        }

        public bool Salvar(Cliente cliente)
        {
            // lógica para persistir cliente
            var sucesso = true;

            if (cliente.TemMudancas && cliente.EhValido)
            {
                if (cliente.EhNovo)
                {
                    // inserir no bd
                }
                else
                {
                    // alterar no bd
                }
            }

            return sucesso;
        }
    }
}
