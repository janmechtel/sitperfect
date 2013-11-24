using System;
using Microsoft.Kinect;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Samples.Kinect.SkeletonBasics
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void TestCalculateAnglesBetweenTwoPoints()
        {
            double expected = 45.0;
            float X1 = 0.0f;
            float Y1 = 0.0f;
            float X2 = 1.0f;
            float Y2 = 1.0f;
            double actual = MainWindow.CalculateAngleBetweenTwoPoints(X1, Y1, X2, Y2);
            Assert.AreEqual(expected, actual, "Angle not calculated correctly");
        }
    }
}
