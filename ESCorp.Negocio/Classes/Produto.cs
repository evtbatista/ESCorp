using ESCorp.Comum;
using ESCorp.Negocio.Classes;

namespace ESCorp.Negocio
{
    public class Produto : EntidadeBase
    {
        
        public int IdProduto { get; private set; }
        private string _nome;
        public string Nome
        {
            get
            {                
                return StringUtil.InserirEspacos(_nome);
            }
            set { _nome = value; }
        }

        public decimal? Preco { get; set; }
        public string Descricao { get; set; }

        public Produto()
        {
            
        }

        public Produto(int idProduto, string nome, decimal preco)
        {
            
        }

        public override bool Validar()
        {
            var ehValido = true;

            if (string.IsNullOrWhiteSpace(Nome))
                ehValido = false;

            if (Preco == null)
                ehValido = false;

            return ehValido;
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}