using System;
using FizzBuzzGenerator;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzGeneratorUnitTests
{
    [TestFixture]
    public class IntExtensionsUnitTests
    {
        [TestCase(10, 5)]
        [TestCase(9, 3)]
        [TestCase(3, 1)]
        public void IsMultipleOf_Should_Retun_True_When_Number_Is_A_Multiple_Of_Divisor(int number, int divisor)
        {
            number.IsMultipleOf(divisor).Should().BeTrue();
        }

        [TestCase(10, 6)]
        [TestCase(9, 5)]
        public void IsMultipleOf_Should_Retun_False_When_Number_Is_Not_A_Multiple_Of_Divisor(int number, int divisor)
        {
            number.IsMultipleOf(divisor).Should().BeFalse();
        }

        [Test]
        public void IsMultipleOf_Should_Retun_False_When_Divisor_Is_Zero_For_Any_Int_Number()
        {
            new Random().Next(100).IsMultipleOf(0).Should().BeFalse();
        }
    }
}
