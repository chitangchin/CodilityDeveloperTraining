using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace CodilityLessons.TimeComplexity.PermMissingElement
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class SolutionClass
    {
        public static int PermMissingEl(int[] A)
        {
            // Implement your solution here
            int permutation = 0;
            //Sum all the elements
            for (int i = 0; i < A.Length; i++)
            {
                //add to the permutation
                permutation += i + 1;
                permutation -= A[i];
            }
            permutation += A.Length + 1;
            return permutation;
        }
    }
}
