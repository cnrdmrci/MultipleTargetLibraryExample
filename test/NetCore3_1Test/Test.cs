using MultipleTargetLibrary;
using NUnit.Framework;

namespace NetCore3_1Test
{
    public class Tests
    {
        [Test]
        public void TestFramework_WhenCallOnNet31Framework_ThenReturnsNet31Framework()
        {
            //When
            var frameworkType = FrameworkHelper.GetFrameworkType();
            
            //Then
            Assert.AreEqual(frameworkType,FrameworkType.NetCore3_1);
        }
    }
}