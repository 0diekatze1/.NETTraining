using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    using System;
    using System.Linq;

    [TestFixture]
    public class ClassesTests
    {
        [Test]
        public void CreateACalculatorClassWithADefaultConstructorAndInstanciate()
        {
            Check.That(new Calculator("Calculateur")).IsNotNull();
        }

        [Test]
        public void AddAnotherConstructorWithAFriendlyNameAndInstanciate()
        {
            Calculator calculator = new Calculator("Calculateur");

            // use a public member for Name for now, i.e public string Name;
            Check.That(calculator.MName).Equals("Calculateur");
        }

        [Test]
        public void AddAMethodThatMakeASumOfAnArrayOfDouble()
        {
            var valuesToSum = new[] { 1.3, 1.7 };
            // add a method Sum to calculator class
            Check.That(valuesToSum.Sum()).Equals(3.0);
        }

        [Test]
        public void AddAMethodOverloadThatMakeASumOfTwoDoubleFromStringRepresentation()
        {
            var sumOfTwoDoubleFromString = "1,0+2";
            // add a method with the same name that uses the previous method
            // tips : use string.Split
            Check.That(Calculator.sum(sumOfTwoDoubleFromString)).Equals(3.0);
        }

        [Test]
        public void AddAGetterForNameInsteadOfPublicNameMember()
        {
            Calculator calculator = new Calculator("Calculator");

            Check.That(calculator.MName).Equals("Calculator");
        }

        [Test]
        public void AddASetterForNameAndChangeNameWithIt()
        {
            Calculator calculator;
            calculator = new Calculator("Calculateur");
            calculator.MName = "Enhanced Calculator";


            Check.That(calculator.MName).Equals("Enhanced Calculator");
        }

        [Test]
        public void UseObjectInitilizerWithDefaultConstructor()
        {

            Check.That(new Calculator().MName).Equals("Calculator");
        }

        [Test]
        public void DefineConstantForPi()
        {
            var sumOfADoubleAndPiConstant = "1,2 + pi";
            // define pi constant (as double) and replace pi string with constant value
            Check.That(Calculator.sum(sumOfADoubleAndPiConstant)).Equals(4.34);
        }
    }
}
