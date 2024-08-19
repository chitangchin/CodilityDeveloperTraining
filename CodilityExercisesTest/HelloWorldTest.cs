using CodilityExercises.HelloWorld;

namespace CodilityExercisesTest
{
    public class HelloWorldTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.HelloWorld(), Is.EqualTo("Hello World"));
        }
    }
}
