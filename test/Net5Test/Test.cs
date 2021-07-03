using MultipleTargetLibrary;
using NUnit.Framework;

namespace Net5Test
{
    public class Tests
    {
        [Test]
        public void TestFramework_WhenCallOnNet5Framework_ThenReturnsNet5Framework()
        {
            //When
            var frameworkType = FrameworkHelper.GetFrameworkType();
            
            //Then
            Assert.AreEqual(frameworkType,FrameworkType.Net5);
        }
    }
}