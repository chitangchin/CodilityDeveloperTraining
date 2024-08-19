using CodilityLessons.HelloWorld;

namespace CodilityLessonsTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.HelloWorld(), Is.EqualTo("Hello World!!"));
        }
    }
}