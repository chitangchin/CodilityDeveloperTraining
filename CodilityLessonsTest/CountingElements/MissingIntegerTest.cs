using CodilityLessons.CountingElements.MissingInteger;

namespace CodilityLessonsTest.CountingElements
{
    public class MissingIntegerTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.MissingInteger([1, 3, 6, 4, 1, 2]), Is.EqualTo(5));
            Assert.That(SolutionClass.MissingInteger([-1, 3, 6, 4, 1, 2]), Is.EqualTo(5));
            Assert.That(SolutionClass.MissingInteger([-14,-12,1,43]), Is.EqualTo(2));
            Assert.That(SolutionClass.MissingInteger([100,000]), Is.EqualTo(1));
            Assert.That(SolutionClass.MissingInteger([5,4,3,2,1]), Is.EqualTo(6));
        }
    }
}
