using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

       
       

 [TestMethod]
        public void Quicksort_RegularIntArrayPassed_ArrayIsSorted()
        {
            int[] source = new[] { 4, 5, 9, 1, 2, 6, 3, 7, 8 };
            var p = 2;

            var r = 5;

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Sorting.Quicksort(source, p, r);
            Assert.AreEqual(expected, source);
        }



        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
