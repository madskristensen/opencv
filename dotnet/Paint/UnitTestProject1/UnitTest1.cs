﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paint;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PaintCanvas pc = new PaintCanvas();
            pc.undo();
            Assert.Fail();
        }
    }
}
