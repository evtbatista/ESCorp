using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCorp.Negocio
{
    public class Telefone
    {

        public Telefone(string ddd, string numero)
        {
            // Técnica de programação defensiva, boa prática para validar os dados antes de serem passados
            // para o construtor, tornando os mais previsíveis.
            if (string.IsNullOrWhiteSpace(ddd))
                throw new ArgumentNullException(nameof(ddd));

            if (string.IsNullOrWhiteSpace(numero))
                throw new ArgumentNullException(nameof(numero));

            Ddd = ddd;
            Numero = numero;
        }

        public string Ddd { get; private set; }
        public string Numero { get; private set; }

    }
}
