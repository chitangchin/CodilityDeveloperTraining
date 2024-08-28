namespace CodilityLessons.Arrays.CyclicRotation
{
    public class SolutionClass
    {
        public static int[] solution(int[] A, int K)
        {
            // Implement your solution here
            //check if array is empty
            if (A.Length == 0)
            {
                return A;
            }
            //Observation: each index is +1 except for the last index. last index should be 0
            //Shift k times
            while (K > 0)
            {
                int lastElement = A[A.Length - 1];

                for (int i = A.Length - 1; i > 0; i--)
                {
                    A[i] = A[i - 1];

                }
                A[0] = lastElement;
                K--;
            }
            return A;
        }
    }
}