using CodilityLessons.PrefixSums.PassingCars;

namespace CodilityLessonsTest.PrefixSums
{
    public class PassingCarsTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.PassingCars([0,1,0,1,1]), Is.EqualTo(5));
        }
    }
}
