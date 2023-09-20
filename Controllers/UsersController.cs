using Curso_TOM.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace Curso_TOM.Controllers
{
    [Route("Usuarios")]
    public class UsersController : Controller
    {
        [Route("Listado")]
        [HttpGet]
        public IActionResult GetList()
        {
            Models.Users.UserListViewModel users = new Models.Users.UserListViewModel();
            users.Users.AddRange(new string[] { "JOAQUIN", "TOMAS", "EMANUEL" });
            return View("Index", users);
        }

        [Route("Crear")]
        [HttpGet]
        public IActionResult Create() // Bind indica que propiedades del modelo permito que se actualicen
        {
            return View();
        }

        [Route("Crear")]
        [HttpPost]
        public IActionResult Create([Bind("Nombre")] UserModel userModel) // Bind indica que propiedades del modelo permito que se actualicen
        {
            return View("Index");
        }
    }
}
