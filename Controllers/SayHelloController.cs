using BestTAsController.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;

        public SayHelloController ( SayHelloServices sayHelloServices )
        {
            _sayHelloServices = sayHelloServices;
        }

        [HttpGet]
        [Route("SayHello/{name}")]
        public string SayHello( string name )
        {
            return _sayHelloServices.SayHello( name );
        }
    }
}