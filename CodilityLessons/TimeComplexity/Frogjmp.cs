namespace CodilityLessons.TimeComplexity.Frogjmp
{
    public class SolutionClass
    {
        public static int Solution(int X, int Y, int D)
        {
            // Implement your solution here
            decimal distance = Y - X;
            decimal result = Math.Ceiling(distance / D);
            return (int)result;
        }
    }
}
