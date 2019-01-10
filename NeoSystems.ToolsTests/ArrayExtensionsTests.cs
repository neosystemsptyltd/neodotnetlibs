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
    public class ArrayExtensionsTests
    {
        [TestMethod()]
        public void ResizeArrayTest()
        {
            // this gives an array with 4 rows and 3 columns
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            // resize the arrayu to 3 rows and 2 columns
            int[,] arr2 = (int[,])arr1.ResizeArray(new int[2] { 3, 2 });

            int arr1y = arr1.GetUpperBound(0) + 1;
            int arr1x = arr1.GetUpperBound(1) + 1;

            int arr2y = arr2.GetUpperBound(0) + 1;
            int arr2x = arr2.GetUpperBound(1) + 1;

            Assert.IsTrue(arr1y == 4);
            Assert.IsTrue(arr1x == 3);
            Assert.IsTrue(arr2.Rank == 2);
            Assert.IsTrue(arr2y == 3);
            Assert.IsTrue(arr2x == 2);

            Assert.IsTrue(arr2[0, 0] == 1);
            Assert.IsTrue(arr2[0, 1] == 2);
            Assert.IsTrue(arr2[1, 0] == 4);
            Assert.IsTrue(arr2[1, 1] == 5);
            Assert.IsTrue(arr2[2, 0] == 7);
            Assert.IsTrue(arr2[2, 1] == 8);
        }
    }
}