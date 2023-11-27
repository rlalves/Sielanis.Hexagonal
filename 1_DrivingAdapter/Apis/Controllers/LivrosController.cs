using ExemploAplication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [Route("ObterLivros")]
        [HttpGet]
        public string ObterLivros()
        {
            return new LivrosApp().ObterLivros();
        }
    }
}
