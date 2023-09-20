using Curso_TOM.Models.Clients;
using Microsoft.AspNetCore.Mvc;

namespace Curso_TOM.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            ClientViewModel clientViewModel = new ClientViewModel() {
                ClientBirth = new DateTime(1997, 10, 14),
                ClientFullName = "Joaquin Diaz",
                ClientId = 5402002
            };

            return View(clientViewModel);
        }
    }
}
