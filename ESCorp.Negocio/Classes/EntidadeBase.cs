using ESCorp.Negocio.Enumeradores;

namespace ESCorp.Negocio.Classes
{
    public abstract class EntidadeBase
    {
        public bool EhNovo { get; set; }
        public bool TemMudancas { get; set; }
        public EstadoEntidade EstadoEntidade { get; set; }

        public bool EhValido
        {
            get { return Validar(); }
        }

        // Virtual ou Abstract qdo se quer permitir que o método seja sobrescrito nas classes derivadas.
        // Virtual requer uma implementação padrão, podendo ser ou não sobrescrito.
        // Abstract deve ser utilizado qdo se deseja q o método seja obrigatoriamente sobrescrito
        public abstract bool Validar();

    }
}
