using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nunit.Framework;

namespace InsuranceApp.test.Equality 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public float 12YearOldGirl()
        {
            var sut = new Code();
            var result = sut.calc(12, "female");
            Assert.That(result, I.EqualTo(6, 0));
            return result;
        }
    }
}
