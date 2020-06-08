using ImageManipulation;

using NUnit.Framework;

using System;
using System.IO;

namespace ImageManipulationTest
{
    public class Tests
    {
        private static readonly string _file = Path.Combine(Path.GetTempPath(), "file.png");
        private ImageResizer _resizer;

        [SetUp]
        public void Setup()
        {
            _resizer = new ImageResizer();

            byte[] bytes = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8/5+hHgAHggJ/PchI7wAAAABJRU5ErkJggg==");
            using (FileStream imageFile = new FileStream(_file, FileMode.Create))
            {
                imageFile.Write(bytes, 0, bytes.Length);
                imageFile.Flush();
            }
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_file))
            {
                File.Delete(_file);
            }
        }

        [Test]
        public void Test1()
        {
            FileInfo file = new FileInfo(_file);
            bool result = _resizer.TryResize(file.FullName, 200, 200);
            Assert.IsTrue(result);
        }
    }
}
