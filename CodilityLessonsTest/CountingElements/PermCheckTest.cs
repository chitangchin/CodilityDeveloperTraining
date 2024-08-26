using CodilityLessons.CountingElements.PermCheck;

namespace CodilityLessonsTest.CountingElements
{
    public class PermCheckTest
    {
        [Test]
        public void Test()
        {
            Assert.That(PermCheck.Solution([1,2,3,4,5,7]), Is.EqualTo(0));
            Assert.That(PermCheck.Solution([1, 2, 3, 4, 5, 6]), Is.EqualTo(1));
            Assert.That(PermCheck.Solution([1, 2, 3, 4, 5, 6, 7, 8, 9]), Is.EqualTo(1));
            Assert.That(PermCheck.Solution([1, 3, 4, 5, 7]), Is.EqualTo(0));
        }
        public void ClarifyingTest()
        {
            Assert.That(PermCheck.Solution([8]), Is.EqualTo(0));
            Assert.That(PermCheck.Solution([1,5]), Is.EqualTo(0));
            Assert.That(PermCheck.Solution([7,8]), Is.EqualTo(0));
            Assert.That(PermCheck.Solution([1]), Is.EqualTo(1));
        }
    }
}
