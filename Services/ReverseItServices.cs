namespace BestTAsController.Services
{
    public class ReverseItServices
    {
        public string ReverseIt( string input )
        {
            string reverse = "";
            for ( int i = input.Length - 1; i >= 0; i-- )
            {
                reverse += input[i];
            }
            return $"When reversed '{input}' is returned as {reverse}";
        }
    }
}