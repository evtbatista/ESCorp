using System;

namespace ESCorp.Negocio
{
    public class Cliente
    {
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
        public string Telefone { get; set; }

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
    }
}
