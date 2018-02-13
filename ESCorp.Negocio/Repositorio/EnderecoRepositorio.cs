using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCorp.Negocio.Repositorio
{
    public class EnderecoRepositorio
    {
        public Endereco Obter(int idEndereco)
        {
            Endereco endereco = new Endereco(idEndereco);

            endereco.Rua = "Rua Duque de Caxias";
            endereco.Numero = "349";
            endereco.Bairro = "Vila Guarani";
            endereco.Cidade = "Mauá";
            endereco.Estado = "SP";
            endereco.Cep = "09310-290";
            endereco.Pais = "Brasil";

            return endereco;
        }

        public IEnumerable<Endereco> ObterPeloIdCliente(int idCliente)
        {
            var enderecos = new List<Endereco>();

            var endereco1 = new Endereco(1)
            {
                TipoEndereco = TipoEndereco.Casa,
                Rua = "Rua 1",
                Numero = "20",
                Bairro = "Jardim Primavera",
                Cidade = "Mauá",
                Estado = "SP",
                Cep = "09361-180",
                Pais = "Brasil"
            };

            enderecos.Add(endereco1);

            var endereco2 = new Endereco(2)
            {
                TipoEndereco = TipoEndereco.Trabalho,
                Rua = "Rua 2",
                Numero = "25",
                Bairro = "Jardim Camila",
                Cidade = "Mauá",
                Estado = "SP",
                Cep = "09361-199",
                Pais = "Brasil"
            };

            enderecos.Add(endereco2);

            return enderecos;
        }

        

        public bool Salvar(Endereco endereco)
        {
            return true;
        }
    }
}
