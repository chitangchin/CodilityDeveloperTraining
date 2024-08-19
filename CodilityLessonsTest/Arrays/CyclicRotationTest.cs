using CodilityLessons.Arrays.CyclicRotation;

namespace CodilityLessonsTest.Arrays
{
    public class CyclicRotationTest
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.solution(new int[] { 3, 8, 9, 7, 6 }, 3), Is.EqualTo(new int[] { 9,7,6,3,8 }));
        }
        [Test]
        public void EmptyTest()
        {
            Assert.That(SolutionClass.solution(new int[] { }, 3), Is.EqualTo(new int[] { }));
        }
    }
}
