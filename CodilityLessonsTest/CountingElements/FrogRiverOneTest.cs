using CodilityLessons.CountingElements.FrogRiverOne;

namespace CodilityLessonsTest.CountingElements
{
    public class FrogRiverOneTest
    {
        [Test]
        public void Test()
        {
            Assert.That(SolutionClass.FrogRiverOne(5, [1,3,1,4,2,3,5,4]), Is.EqualTo(6));
        }
    }
}
