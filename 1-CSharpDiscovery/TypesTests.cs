using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class TypesTests
    {
        [Test]
        public void NFluentAndNUnitAreWorking()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void AnIntIsNotEqualToSameIntStringRepresentation()
        {
            Check.That(1).Not.Equals("1");
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsFloat()
        {
            Check.That((float)1).Not.Equals(1);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDouble()
        {
            Check.That((double)1).Not.Equals(1);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDecimal()
        {
            Check.That((decimal)1).Not.Equals(1);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsLong()
        {
            Check.That((long)1).Not.Equals(1);
        }

        [Test]
        public void AnIntIsEqualToSameIntAsInt32()
        {
            Check.That((Int32)1).Equals(1);
        }

        [Test]
        public void AFloatCanBeCastedToInteger()
        {
            float single = 1.0F;
            int expectedInteger = 1;

            Check.That((int)single).Equals(expectedInteger);
        }

        //[Test]
        //public void AnIntCanBeImplicitlyCastedToFloat()
        //{
        //    int integer = 1;
        //    float expectedSingle = 1F;
        //    Check.That((int)integer).Equals(expectedSingle);
        //}

        [Test]
        public void AStringCanBeParsedToInteger()
        {
            string integerString = "30";
            int expectedInteger = 30;

            Check.That(Convert.ToInt32(integerString)).Equals(expectedInteger);
        }

        [Test]
        public void AFloatStringRepresentationCannotBeParsedToInteger()
        {
            Assert.Throws<FormatException>(() => { Convert.ToInt32("3.0"); });
            // Create a method named ParseFloatStringAsInteger that takes no argument, return void and parse a float string representation "30.0"
           // Check.That(Convert.ToInt32("3.0"))<InvalidCastException>();
        }

        [Test]
        public void TryToParseAStringToInteger()
        {
            string floatString = "30.0";
            string intString = "30";
            int expectedInteger = 30;
            int generatedInt;

            int.TryParse(intString, out generatedInt);

            // Use int.TryParse, /!\ it uses an "out" argument

            Check.That(generatedInt).Equals(expectedInteger);
            int.TryParse(floatString, out generatedInt);
            Check.That(int.TryParse(floatString, out generatedInt)).Equals(false);
        }

        [Test]
        public void UseVarForLessVerbosityButKeepStrongTyping()
        {
            var mInt = 1;
            var mString = "1";

            Check.That(mString).Not.Equals(mInt);
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue()
        {
            // use "int?" to declare a nullable int initialized with null, then try also with Nullable<int>

            int? mIntNullable = null;
            Check.That(mIntNullable.HasValue).IsFalse();
        }

        [Test]
        public void GettingValueOfANullableIntwithNullValueThrowsAnInvalidOperationException()
        {
            
            // Create a method named GetNullableIntValue that takes no argument, return void and access a nullable int value (nullableInteger.Value)
            //Check.That().Throws<InvalidOperationException>();
            Assert.Throws<InvalidOperationException>(() =>
            {
                int? mIntNullable=null;
                mIntNullable= mIntNullable.Value + 1;
            });
        }

    }
}
