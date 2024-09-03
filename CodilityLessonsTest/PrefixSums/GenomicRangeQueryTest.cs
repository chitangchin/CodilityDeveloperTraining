using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodilityLessons.PrefixSums.GenomicRangeQuery;

namespace CodilityLessonsTest.PrefixSums
{
    public class GenomicRangeQueryTest
    {
        private readonly int[] expected = [2, 4, 1];
        private readonly int[] expected2 = [3, 3, 3, 3, 3];
        private readonly int[] expected3 = [1, 4, 1, 4, 1, 4];
        [Test]
        public void TestExample()
        {
            string S = "CAGCCTA";
            int[] P = { 2, 5, 0 };
            int[] Q = { 4, 5, 6 };
            Assert.That(SolutionClass.Solution(S, P, Q), Is.EqualTo(expected));
        }
        [Test]
        public void TestSameNucleotide()
        {
            string S = "GGGGG";
            int[] P = { 0, 1, 2, 3, 4 };
            int[] Q = { 0, 1, 2, 3, 4 };
            Assert.That(SolutionClass.Solution(S, P, Q), Is.EqualTo(expected2));
        }
        [Test]
        public void TestNoOccurrences()
        {
            string S = "ATATAT";
            int[] P = { 0, 1, 2, 3, 4, 5 };
            int[] Q = { 0, 1, 2, 3, 4, 5 };
            Assert.That(SolutionClass.Solution(S, P, Q), Is.EqualTo(expected3));
        }
    }
}
