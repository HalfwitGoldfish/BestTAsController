using BestTAsController.models;

namespace BestTAsController.Services
{
    public class SayHelloTwoServices
    {
        public string SayHelloTwo( SayHelloTwoModel sayHelloTwoModel )
        {
            return $"Hello {sayHelloTwoModel}";
        }
    }
}