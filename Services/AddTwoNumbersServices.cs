namespace BestTAsController.Services
{
    public class AddTwoNumbersServices
    {
        public string Add(string num1, string num2)
        {
            int parsed1;
            int parsed2;
            bool check1 = int.TryParse( num1, out parsed1 );
            bool check2 = int.TryParse( num2, out parsed2 );
            if ( check1 && check2 )
            {
                return $"The sum of {parsed1} plus {parsed2} is equal to {parsed1 + parsed2}";
            }
            return $"Error either {parsed1} or {parsed2} is not valid";
        }
    }
}