namespace Mac.MAUI.Entities.Response
{
    public class ContratoResponse
    {
        public ContratoResponse(string empreendimento, string bloco, string unidade, string contrato, DateTime dataVenda)
        {
            Empreendimento = empreendimento;
            Bloco = bloco;
            Unidade = unidade;
            Contrato = contrato;
            DataVenda = dataVenda;
        }

        public string Empreendimento { get; set; }
        public string Bloco { get; set; }
        public string Unidade { get; set; }
        public string Contrato { get; set; }
        public DateTime DataVenda  { get; set; }

    }
}
