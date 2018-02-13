using System;

namespace ESCorp.Negocio
{
    public class Endereco
    {
        public Endereco()
        {
            
        }

        public Endereco(int idEndereco)
        {
            IdEndereco = idEndereco;
        }

        public int IdEndereco { get; private set; }

        public TipoEndereco TipoEndereco { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }

    }
}
