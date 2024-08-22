namespace CodilityLessons.CountingElements.FrogRiverOne
{
    public class SolutionClass
    {
        public static int FrogRiverOne(int X, int[] A)
        {
            // Implement your solution here
            //initially on position 0 and get to x+1 position
            //5 , 4 , 3, 2 ,1 => -1, -2, -3, -4, -5 return index
            //Stack - we will start with 0 in stack then we check for 1 when we see one then we push to stack, then look for 2. Once we look for x, and we find x then we return the index
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 1; i <= X; i++)
            {
                map.Add(i, 1);
            }

            int index = 0;
            while (index < A.Length)
            {
                if (map.ContainsKey(A[index]) && map[A[index]] > 0)
                {
                    map.Remove(A[index]);
                }
                if (map.Count == 0) break;
                index++;
            }
            if (map.Count > 0) return -1;
            return index;
        }
    }
}
