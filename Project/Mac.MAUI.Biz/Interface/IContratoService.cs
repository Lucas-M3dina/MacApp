using Mac.MAUI.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac.MAUI.Biz.Interface
{
    public interface IContratoService
    {
        public List<ContratoResponse> ListarContratos();
    }
}
