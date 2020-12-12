using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Operacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {

        [HttpGet]
        public string Operaiones( int numero)
        {
            string respuesta = "";
            if (numero < 0)
            { respuesta = "ERROR"; }

            if (numero == 0)
            { respuesta = "Realizado por Anahi Agreda"; }

            if (numero > 0)
            { respuesta = "https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg"; }
            return respuesta;

        }
    }
}
