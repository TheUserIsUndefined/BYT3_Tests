using BYT3_Calculator;
using BYT3_Calculator.Exceptions;

namespace Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _add = new Calculator(12345, 54321, '+');
        private readonly Calculator _sub = new Calculator(23456, 65432, '-');
        private readonly Calculator _mul = new Calculator(34567, 76543, '*');
        private readonly Calculator _div = new Calculator(45678, 91356, '/');
        private readonly Calculator _divByZero = new Calculator(1, 0, '/');
        private readonly Calculator _unknownOp = new Calculator(1, 1, '^');
        private readonly Calculator _boundariesOverflow = new Calculator(1e155, 1e155, '*');
        private readonly Calculator _boundariesUnderflow = new Calculator(-1e155, 1e155, '*');
        
        [Test]
        public void TestAddition()
        {
            Assert.That(_add.Calculate(), Is.EqualTo(66666));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.That(_sub.Calculate(), Is.EqualTo(-41976));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(_mul.Calculate(), Is.EqualTo(2645861881));
        }

        [Test]
        public void TestDivision()
        {
            Assert.That(_div.Calculate(), Is.EqualTo(0.5));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _divByZero.Calculate());
        }

        [Test]
        public void TestUnknownOperation()
        {
            Assert.Throws<UnknownOperationException>(() => _unknownOp.Calculate());
        }

        [Test]
        public void TestBoundariesOverflow()
        {
            Assert.Throws<BoundariesExceededException>(() => _boundariesOverflow.Calculate());
        }
        
        [Test]
        public void TestBoundariesUnderflow()
        {
            Assert.Throws<BoundariesExceededException>(() => _boundariesUnderflow.Calculate());
        }
    }
}