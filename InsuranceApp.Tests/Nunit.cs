using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InsuranceApp.Tests.Equality
{
    [TestFixture]
    public class Nunit
    {
        [Test]
        public void TwelveYearOldGirl()
        {
            var sut = new CodeFromFile();
            var result = sut.CalcPremium(12, "female");
            Assert.That(result, Is.EqualTo(0.0));            
        }
        [Test]
        public void NineteenYearOldGirl()
        {
            var sut = new CodeFromFile();
            var result = sut.CalcPremium(19, "female");
            Assert.That(result, Is.EqualTo(5.0));
        }
        [Test]
        public void FiftyOneYearOldGirl()
        {
            var sut = new CodeFromFile();
            var result = sut.CalcPremium(51, "female");
            Assert.That(result, Is.EqualTo(2.5));
        }
        [Test]
        public void SeventeenYearOldMan()
        {
            var sut = new CodeFromFile();
            var result = sut.CalcPremium(17, "male");
            Assert.That(result, Is.EqualTo(0.0));
        }
        [Test]
        public void ThirtyYearOldMan()
        {
            var sut = new CodeFromFile();
            var result = sut.CalcPremium(30, "male");
            Assert.That(result, Is.EqualTo(6.0));
        }
        [Test]
        public void ThirtySixYearOldMan()
        {
            var sut = new CodeFromFile();
            var result = sut.CalcPremium(36, "male");
            Assert.That(result, Is.EqualTo(5.0));
        }
        [Test]
        public void NoGender()
        {
            var sut = new CodeFromFile(); 
            var result = sut.CalcPremium(25, "null");
            Assert.That(result, Is.EqualTo(0.0));
        }
    }
}
