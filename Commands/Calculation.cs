using Microsoft.AspNetCore.Mvc;
using TesteBOOSTIT.Model.Request;
using TesteBOOSTIT.Model.Result;

namespace TesteBOOSTIT.Commands
{
    public class Calculation : ICalculation
    {
        public async Task<Multiplos> GetDivisibilityEleven(Request request)
        {
            List<Result> result = new List<Result>();   
            foreach (var number in request.Numbers)
            {
                if(check(number))
                {
                    result.Add(new Result {
                        number = number,
                        isMultiple = true
                    });
                }
                else
                {
                    result.Add(new Result
                    {
                        number = number,
                        isMultiple = false
                    });
                }
            }

            Multiplos multiplos = new Multiplos();
            multiplos.Result = result;
            return multiplos;
        }

        static bool check(long n)
        {
            // Compute sum of even and odd digit
            // sums
            int oddDigSum = 0, evenDigSum = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                // When i is even, position of digit is odd
                if (i % 2 == 0)
                    oddDigSum += (n.ToString()[i] - 0);
                else
                    evenDigSum += (n.ToString()[i] - 0);
            }

            // Check its difference is divisible by 11 or not
            return ((oddDigSum - evenDigSum) % 11 == 0);
        }
    }
}
