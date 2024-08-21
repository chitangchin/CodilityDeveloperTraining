namespace CodilityLessons.TimeComplexity.TapeEquilibrium
{
    public class SolutionClass
    {
        public static int TapeEquilibrium(int[] A)
        {
            // Implement your solution here
            int firstPart = A[0], secondPart = Sum(A) - firstPart;
            int currMin = Math.Abs(firstPart - secondPart);
            for (int i = 1; i < A.Length; i++)
            {
                if (Math.Abs(firstPart - secondPart) < currMin) currMin = Math.Abs(firstPart - secondPart);
                firstPart += A[i];
                secondPart -= A[i];
            }
            return currMin;
        }
        public static int Sum(int[] arg)
        {
            int totalSum = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                totalSum += arg[i];
            }
            return totalSum;
        }
    }
}
