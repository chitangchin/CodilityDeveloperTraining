using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons.PrefixSums.CountingDiv
{
    public class SolutionClass
    {
        public static int Solution(int A, int B, int K)
        {
            // Implement your solution here
            int bDivisibleByK = B / K;
            int aDivisibleByK = A / K;
            int inclusive = (A % K == 0 ? 1 : 0);
            return bDivisibleByK - aDivisibleByK + inclusive;
        }
    }
}
