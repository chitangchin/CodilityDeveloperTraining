namespace CodilityLessons.CountingElements.MaxCounters
{
    public class SolutionClass
    {
        public static int[] Solution(int N, int[] A)
        {
            // Implement your solution here
            /*Given N counters, initially set to 0
             * 
             * Two possible operations:
             * increase(x) counter x is increased by 1
             * max counter - all counters are set to maximum valie of any countera
             * 
             * non empty array A of M integers is given
             * Array A represents consecutive operations
             * if A[K] = X such taht 1 <= X <= N then operation K is increase(X)
             * if A[K] = N + 1 then operation K is maxCounter
            */
            //Store a current max counter = 0;
            int currentMax = 0;
            int resetLimit = 0;

            //Create an array of size N with all 0 elements
            int[] resultArr = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N && 1 <= A[i])
                {
                    if (resultArr[A[i] - 1] < resetLimit)
                    {
                        resultArr[A[i] - 1] = resetLimit + 1;
                    }
                    else
                    {
                        resultArr[A[i] - 1]++;
                    }
                    if (resultArr[A[i] - 1] > currentMax)
                    {
                        currentMax = resultArr[A[i] - 1];
                    }
                }
                else
                {
                    //This you only have to do once if there are multiple 
                    resetLimit = currentMax;
                }
            }

            for (int i = 0; i < resultArr.Length; i++)
                resultArr[i] = Math.Max(resetLimit, resultArr[i]);

            return resultArr;
         }
    }
}
