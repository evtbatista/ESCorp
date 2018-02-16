using System;

namespace ESCorp.Comum.Teste
{
    public class MensagemEmailFake : IMensagemEmail
    {
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }
        public bool Enviar()
        {
            Console.WriteLine($"Enviado email para {Destinatario}. Assunto: {Assunto}");

            return true;
        }

        public bool ValidarEmailDestinatario()
        {
            return true;
        }

        public bool EnviarEmailComAnexo()
        {
            return true;
        }
    }
}
