using ImageManipulation;

using NUnit.Framework;

using System.IO;

namespace ImageManipulationTest
{
    public class Tests
    {
        private ImageResizer _resizer;

        [SetUp]
        public void Setup()
        {
            _resizer = new ImageResizer();
        }

        [Test]
        public void Test1()
        {
            FileInfo file = new FileInfo(@"..\..\..\artifacts\file.png");
            bool result = _resizer.TryResize(file.FullName, 200, 200);
            Assert.IsTrue(result);
        }
    }
}
