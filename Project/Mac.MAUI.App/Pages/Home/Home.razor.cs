using Mac.MAUI.Biz.Interface;
using Mac.MAUI.Biz.Service;
using Mac.MAUI.Entities.Response;
using Microsoft.AspNetCore.Components;
namespace Mac.MAUI.Pages.Home
{
    public partial class Home : ComponentBase
    {
        private List<ContratoResponse> contratos = [];

        [Inject]
        public IContratoService ContratoService { get; set; }

        public void ListarContratos()
        {
            contratos =  ContratoService.ListarContratos();
        }


        protected override async Task OnInitializedAsync()
        {
             ListarContratos();
        }
    }
}
