namespace ESCorp.Comum
{
    public interface IMensagem
    {        
        string Corpo { get; set; }
        string Destinatario { get; set; }
        string Remetente { get; set; }
        bool Enviar();
    }

    public interface IMensagemEmail: IMensagem
    {
        string Assunto { get; set; }
        bool ValidarEmailDestinatario();
        bool EnviarEmailComAnexo();
    }
}