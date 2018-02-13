namespace ESCorp.Negocio
{
    public class ItemPedido
    {
        public ItemPedido()
        {
            
        }

        public ItemPedido(int idItemPedido, int idProduto, int quantidade, decimal precoCompra)
        {
            IdItemPedido = idItemPedido;
            IdProduto = idProduto;
            Quantidade = quantidade;
            PrecoCompra = precoCompra;
        }

        public int IdItemPedido { get; private set; }
        public int Quantidade { get; set; }
        public int IdProduto { get; set; }
        public decimal? PrecoCompra { get; set; }

        public decimal Total => Quantidade * PrecoCompra.Value;

        public ItemPedido Obter()
        {
            return new ItemPedido();
        }

        public bool Salvar()
        {
            return true;
        }

        public bool Validar()
        {
            if (Quantidade <= 0)
                return false;
            if (IdProduto <= 0)
                return false;
            if (PrecoCompra == null)
                return false;

            return true;
        }
    }
}
