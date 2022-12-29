using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    internal class Class1
    {
        [Test]
        public void AdditionalCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Additional(100, 50) == 150);
        }
        [Test]
        public void SubtractionCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(100, 50) == 50);
        }
        [Test]
        public void MiltiplicationCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Miltiplication(100, 51) == 5100);
        }
        [Test]
        public void DivisionCorrectResult()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(100, 50) == 2);
        }
        [Test]
        public void DivisionDivideByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Catch<DivideByZeroException>(() => calculator.Division(100, 0));
        }
    }
}

