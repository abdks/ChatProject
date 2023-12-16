using Chating.AbstractBus;
using Microsoft.AspNetCore.Mvc;

namespace Chating.Controllers
{
    public class denemeController : Controller
    {
        private readonly IDeneService _service;

        public denemeController(IDeneService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var values = _service.TGetListAll();
            return View(values);
        }
    }
}
