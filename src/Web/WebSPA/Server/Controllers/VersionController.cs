// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using eShopOnContainers.WebSPA;

namespace eShopConContainers.WebSPA.Server.Controllers
{
    public class VersionController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IOptionsSnapshot<AppSettings> _settings;

        public VersionController(IWebHostEnvironment env, IOptionsSnapshot<AppSettings> settings)
        {
            _env = env;
            _settings = settings;
        }

        [HttpGet]
        public IActionResult Git()
        {
            return Json(ThisAssembly.Git.Sha);
        } 
    }
}
