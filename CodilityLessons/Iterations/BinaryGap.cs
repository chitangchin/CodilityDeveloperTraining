namespace CodilityLessons.Iterations.BinaryGap
{
    public class SolutionClass
    {
        public static int BinaryGap(int N)
        {
            //Convert decimal N into binary
            string binaryN = DecimalToBinary(N);

            int maxCounter = 0;
            int zeroCounter = 0;

            for (int i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[i] == '1')
                {
                    if (zeroCounter > maxCounter)
                    {
                        maxCounter = zeroCounter;
                    }
                    zeroCounter = 0;
                }
                else
                {
                    zeroCounter++;
                }
            }
            return maxCounter;
        }
        public static string DecimalToBinary(int N)
        {
            if (N < 2) return N.ToString();

            int divisor = N / 2;
            int remainder = N % 2;

            return DecimalToBinary(divisor) + remainder;
        }
    }
}
