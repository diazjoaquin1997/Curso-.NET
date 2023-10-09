using Curso_TOM.Models.Clients;
using Microsoft.AspNetCore.Mvc;

namespace Curso_TOM.Controllers
{
    public class ClientsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //TOMService.Service1Client service = new TOMService.Service1Client();
            //var x = await service.GetDataAsync(1);

            ServiceReference1.ServiceClient serviceReference = new ServiceReference1.ServiceClient();
            string nombre = serviceReference.GetNombreAsync(40420273).Result;

            ClientViewModel clientViewModel = new ClientViewModel() {
                ClientBirth = new DateTime(1997, 10, 14),
                ClientFullName = nombre,
                ClientId = 213
            };

            return View(clientViewModel);
        }
    }
}
