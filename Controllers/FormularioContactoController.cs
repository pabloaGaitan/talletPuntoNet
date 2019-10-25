using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tallerPuntoNet.Models;

namespace tallerPuntoNet.Controllers
{
    public class FormularioContactoController : Controller
    {
        private readonly ILogger<FormularioContactoController> _logger;

        public FormularioContactoController(ILogger<FormularioContactoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contacto fc)
        {
            if(ModelState.IsValid){
                return Redirect("/Home/Privacy");
            }
            return View(fc);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [Route("/contacto")]
        
        public Contacto crearContacto(Contacto fc)
        {
            return fc;
        }


    }
}
