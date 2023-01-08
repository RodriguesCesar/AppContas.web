using AppContas.Web.Responses;

namespace AppContas.web.Responses
{
    public class CadastrarContaResponse
    {
        public string? Mensagem { get; set; }
        public ContaResponse? Conta { get; set; }
    }
}
