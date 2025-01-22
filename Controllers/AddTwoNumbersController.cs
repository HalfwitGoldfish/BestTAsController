using BestTAsController.Services;
using Microsoft.AspNetCore.Mvc;

namespace BestTAsController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;

        public AddTwoNumbersController ( AddTwoNumbersServices addTwoNumbersServices )
        {
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string Add( string num1, string num2 )
        {
            return _addTwoNumbersServices.Add( num1, num2 );
        }
    }
}