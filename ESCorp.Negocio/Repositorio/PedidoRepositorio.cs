using System;
using System.Collections.Generic;
using ESCorp.Negocio.DTO;

namespace ESCorp.Negocio.Repositorio
{
    public class PedidoRepositorio
    {
        public Pedido Obter(int idPedido)
        {
            return new Pedido();
        }

        public PedidoDto ObterPedidoParaExibicao(int idPedido)
        {
            var pedidoDto = new PedidoDto()
            {
                IdPedido = idPedido,
                Nome = "Bruce",
                SobreNome = "Wayne",
                DataPedido = DateTime.Today,
                EnderecoDeEntrega = new Endereco(1)
                {
                    TipoEndereco = TipoEndereco.Casa,
                    Rua = "Rua 1",
                    Numero = "20",
                    Bairro = "Jardim Primavera",
                    Cidade = "Mauá",
                    Estado = "SP",
                    Cep = "09361-180",
                    Pais = "Brasil"
                }
            };

            pedidoDto.Itens = new List<ItemPedidoDto>();

            var itemPedidoDto = new ItemPedidoDto()
            {
                NomeProduto = "XBOX One",
                PrecoDeCompra = 1500,
                Quantidade = 1
            };

            pedidoDto.Itens.Add(itemPedidoDto);

            itemPedidoDto = new ItemPedidoDto()
            {
                NomeProduto = "Playstation 4",
                PrecoDeCompra = 2000,
                Quantidade = 1
            };

            pedidoDto.Itens.Add(itemPedidoDto);

            return pedidoDto;
        }

        public bool Salvar()
        {
            return true;
        }
    }
}
