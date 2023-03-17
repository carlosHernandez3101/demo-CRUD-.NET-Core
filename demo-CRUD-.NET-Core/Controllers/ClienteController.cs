using Microsoft.AspNetCore.Mvc;

namespace demo_CRUD_.NET_Core.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listerClient()
        {
            return null;
        }

        //[HttpPost]
        //[Route("guardar")]

        //public dynamic saveClient()
        //{

        //}
    }
}
