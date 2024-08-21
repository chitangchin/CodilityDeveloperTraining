namespace CodilityLessons.Arrays.OddOccurrencesInArray
{
    public class SolutionClass
    {
        public static int OddOccurrences(int[] A)
        {
            //Create a dictionary
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in A)
            {
                if (map.ContainsKey(num))
                {
                    map.Remove(num);
                }
                else
                {
                    map.Add(num, 1);
                }
            }

            int result = 0;
            foreach (KeyValuePair<int, int> num in map)
            {
                result += num.Key;
            }
            return result;
        }
    }
}
