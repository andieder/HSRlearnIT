using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void MainWindowTest()
        {
            Assert.Fail();
        }

        //Adding some comment for bla-Branch

        [TestMethod()]
        public void testClickTest()
        {
            int a = 5;
            Assert.AreEqual(a, MainWindow.testClick(5));
        }
    }
}