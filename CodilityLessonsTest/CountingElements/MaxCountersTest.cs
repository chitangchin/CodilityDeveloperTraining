using CodilityLessons.CountingElements.MaxCounters;

namespace CodilityLessonsTest.CountingElements
{
    public class MaxCountersTest
    {
        private readonly int[] expected = [3, 2, 2, 4, 2];
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.Solution(5, [3, 4, 4, 6, 1, 4, 4]), Is.EqualTo(expected));
        }
    }
}
