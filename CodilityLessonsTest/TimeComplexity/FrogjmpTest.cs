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
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.Solution(1101, 120302031, 59), Is.EqualTo(2038999));
        }
        [Test]
        public void Test2()
        {
            Assert.That(SolutionClass.Solution(100, 250, 100), Is.EqualTo(2));
        }
        [Test]
        public void Test3()
        {
            Assert.That(SolutionClass.Solution(99, 210, 62), Is.EqualTo(2));
        }
    }
}
