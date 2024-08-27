using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons.CountingElements.MissingInteger
{
    public class SolutionClass
    {
        public static int MissingInteger(int[] A)
        {
            int numCheck = 1;
            bool found = false;
            Array.Sort(A);

            while (found == false)
            {
                if (Array.BinarySearch(A, numCheck) < 0)
                {
                    found = true;
                    break;
                }
                numCheck += 1;
            }
            return numCheck;
        }
    }
}
