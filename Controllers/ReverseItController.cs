using BestTAsController.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItServices _reverseItServices;

        public ReverseItController ( ReverseItServices reverseItServices )
        {
            _reverseItServices = reverseItServices;
        }

        [HttpGet]
        [Route("ReverseIt/{input}")]
        public string ReverseIt ( string input )
        {
            return _reverseItServices.ReverseIt( input );
        }
    }
}