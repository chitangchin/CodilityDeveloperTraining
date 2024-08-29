using CodilityLessons.PrefixSums.CountingDiv;
namespace CodilityLessonsTest.PrefixSums
{
    public class CountingDivTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.Solution(6, 11, 2), Is.EqualTo(3));
        }
    }
}
