using CodilityLessons.Iterations.BinaryGap;

namespace CodilityLessonsTest.Iterations
{
    [TestFixture]
    public class BinaryGapTests
    {
        [Test]
        public void RunTests()
        {
            Assert.That(SolutionClass.BinaryGap(15), Is.EqualTo(0));
        }
        [Test]
        public void LargeTests()
        {
            Assert.That(SolutionClass.BinaryGap(1041), Is.EqualTo(5));
        }
    }
}
