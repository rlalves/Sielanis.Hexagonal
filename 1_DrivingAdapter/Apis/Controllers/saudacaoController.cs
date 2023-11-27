using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class saudacaoController : ControllerBase
    {
        [HttpGet]
        public string Alo() => "Alo mundo.";
    }
}
