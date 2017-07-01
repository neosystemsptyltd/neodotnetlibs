using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeoSystems.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSystems.Tools.Tests
{
    [TestClass()]
    public class FileUtilsTests
    {
        [TestMethod()]
        public void MakeValidFileNameTest()
        {
            try
            {
                string invalid1 = "capeesh?.txt";

                Assert.IsTrue(FileUtils.MakeValidFileName(invalid1) == "capeesh_.txt");
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}