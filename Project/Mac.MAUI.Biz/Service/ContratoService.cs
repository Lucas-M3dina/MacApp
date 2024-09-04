using Mac.MAUI.Biz.Interface;
using Mac.MAUI.Data.Context;
using Mac.MAUI.Entities.Response;
using Microsoft.EntityFrameworkCore;

namespace Mac.MAUI.Biz.Service
{
    public class ContratoService : IContratoService
    {
        private readonly MacAppContext _context;

        public ContratoService(MacAppContext context)
        {
            _context = context;
        }

        public List<ContratoResponse> ListarContratos()
        {
            return _context.Contrato
                .AsNoTracking()
                .Select(contrato => new ContratoResponse
                (
                    contrato.Nm_Empreendimento,
                    contrato.Nm_Bloco,
                    contrato.Nm_Unidade,
                    contrato.Nm_Contrato,
                    contrato.Dt_DataVenda
                ))
                .ToList();
        }
    }
}
