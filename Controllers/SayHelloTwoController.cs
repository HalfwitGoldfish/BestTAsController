using BestTAsController.models;
using BestTAsController.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloTwoController : ControllerBase
    {
        private readonly SayHelloTwoServices _sayHelloTwoServices;

        public SayHelloTwoController ( SayHelloTwoServices sayHelloTwoServices )
        {
            _sayHelloTwoServices = sayHelloTwoServices;
        }

        [HttpGet]
        [Route("SayHelloTwo")]
        public string SayHelloTwo( SayHelloTwoModel sayHelloTwoModel )
        {
            return _sayHelloTwoServices.SayHelloTwo( sayHelloTwoModel );
        }
    }
}