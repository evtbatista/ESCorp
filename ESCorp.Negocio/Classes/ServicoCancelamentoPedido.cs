
using System.Net.Mail;
using ESCorp.Comum;

namespace ESCorp.Negocio.Classes
{
    public class ServicoCancelamentoPedido
    {
        private IMensagemEmail _mensagem;
        //Princípio de Injeção de Dependência, fazendo com que a classe ServicoCancelamentoPedido dependa de um módulo de 
        // alto nível (IMensagem) e não de MensagemEmail.
        public ServicoCancelamentoPedido(IMensagemEmail mensagem)
        {
            _mensagem = mensagem;
        }

        public void CancelarPedido(Pedido pedido)
        {
            pedido.Cancelar();

            _mensagem.Remetente = "evtbatista@gmail.com.br";
            _mensagem.Destinatario = "everton.batista@thomasgreg.com.br";
            _mensagem.Assunto = "Pedido Cancelado";
            _mensagem.Corpo = $"Pedido {pedido.ToString()} cancelado.";

            _mensagem.Enviar();
        }
    }
}
