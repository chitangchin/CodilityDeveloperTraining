using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons.PrefixSums.PassingCars
{
    public class SolutionClass
    {
        public static int PassingCars(int[] A)
        {
            /*
             Given: non empty array A
            N integers given

            0s or 1s

            0: car traveling east
            1: car traveling west
            0 1 2 3 4  
            >   > 
              <   < <
             */
            //how many 1's are there in an index greater and equal to 0? sum th passes
            int sumPasses = 0;
            int eastCars = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) eastCars += 1;
                if (A[i] == 1) sumPasses += eastCars;
                if (sumPasses > 1000000000) return -1;
            }
            return sumPasses;
        }
    }
}
