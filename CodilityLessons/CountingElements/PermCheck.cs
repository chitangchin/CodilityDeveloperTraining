namespace CodilityLessons.CountingElements.PermCheck
{
    public class PermCheck
    {
        public static int Solution(int[] A)
        {
            //None empty array with N Integers given
            //Goal: check if the array is a permutation or not

            // Implement your solution here
            Array.Sort(A);
            if (A[0] != 1) return 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] - 1 != A[i - 1]) return 0;
            }
            return 1;
        }
    }
}
