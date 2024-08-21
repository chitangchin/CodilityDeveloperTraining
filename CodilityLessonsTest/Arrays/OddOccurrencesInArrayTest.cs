using CodilityLessons.Arrays.OddOccurrencesInArray;

namespace CodilityLessonsTest.Arrays
{
    public class OddOccurrencesInArrayTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.OddOccurrences(new int[] {3,3,9,9,9,9,7}), Is.EqualTo(7));
        }
    }
}
