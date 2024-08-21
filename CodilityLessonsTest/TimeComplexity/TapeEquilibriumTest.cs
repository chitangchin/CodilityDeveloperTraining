using CodilityLessons.TimeComplexity.TapeEquilibrium;

namespace CodilityLessonsTest.TimeComplexity
{
    public class TapeEquilibriumTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.TapeEquilibrium([3,1,2,4,3]), Is.EqualTo(1));
        }
    }
}
