using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLessons.PrefixSums.GenomicRangeQuery
{
    public class SolutionClass
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            int dnaLength = S.Length;
            int queryLength = P.Length;
            int[] result = new int[queryLength];

            // Create prefix sums for each nucleotide type
            int[] prefixSumA = new int[dnaLength + 1];
            int[] prefixSumC = new int[dnaLength + 1];
            int[] prefixSumG = new int[dnaLength + 1];
            int[] prefixSumT = new int[dnaLength + 1];

            for (int i = 0; i < dnaLength; i++)
            {
                prefixSumA[i + 1] = prefixSumA[i] + (S[i] == 'A' ? 1 : 0);
                prefixSumC[i + 1] = prefixSumC[i] + (S[i] == 'C' ? 1 : 0);
                prefixSumG[i + 1] = prefixSumG[i] + (S[i] == 'G' ? 1 : 0);
                prefixSumT[i + 1] = prefixSumT[i] + (S[i] == 'T' ? 1 : 0);
            }

            // Process each query
            for (int i = 0; i < queryLength; i++)
            {
                int start = P[i];
                int end = Q[i] + 1;
                // Add 1 to make the range inclusive
                // Check each nucleotide type in the range and find the minimum impact factor
                if (prefixSumA[end] - prefixSumA[start] > 0)
                    result[i] = 1;
                else if (prefixSumC[end] - prefixSumC[start] > 0)
                    result[i] = 2;
                else if (prefixSumG[end] - prefixSumG[start] > 0)
                    result[i] = 3;
                else
                    result[i] = 4;
            }

            return result;
        }
    }
}
