using System.Net;
using System.Net.Mail;

namespace ESCorp.Comum
{
    public class MensagemEmail : IMensagemEmail
    {
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Corpo { get; set; }

        public bool Enviar()
        {
            var mensagemEmail = new MailMessage(Remetente, Destinatario, Assunto, Corpo);

            SmtpClient client = new SmtpClient("localhost");            
            client.Send(mensagemEmail);

            return true;
        }

        public bool ValidarEmailDestinatario()
        {
            //Lógica para validar email
            return true;
        }

        public bool EnviarEmailComAnexo()
        {
            throw new System.NotImplementedException();
        }
    }

    public class MensagemSms : IMensagem
    {        
        public string Corpo { get; set; }
        public string Destinatario { get; set; }
        public string Remetente { get; set; }

        public bool Enviar()
        {
            throw new System.NotImplementedException();
        }

    }
}
