using CodilityLessons.TimeComplexity.Frogjmp;

namespace CodilityLessonsTest.TimeComplexity
{
    public class FrogjmpTest
    {
        [Test]
        public void Test() 
        {
            Assert.That(SolutionClass.Solution(1,2,2), Is.EqualTo(1));
        }
    }
}
