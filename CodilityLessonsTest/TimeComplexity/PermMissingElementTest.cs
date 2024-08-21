using CodilityLessons.TimeComplexity.PermMissingElement;

namespace CodilityLessonsTest.TimeComplexity
{
    public class PermMissingElementTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.PermMissingEl([1, 3, 2, 5]), Is.EqualTo(4));
        }
        [Test]
        public void EmptyTest()
        {
            Assert.That(SolutionClass.PermMissingEl([]), Is.EqualTo(1));
        }
    }
}
