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
    public class ContactoAPIController : Controller
    {

        [HttpPost]
       
        
        public Contacto Index([FromBody]Contacto fc)
        {
            return fc;
        }


    }
}
