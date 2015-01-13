using System.Linq;
using FizzBuzzGenerator;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzzGeneratorUnitTests
{
    [TestFixture]
    public class SequenceGeneratorUnitTests
    {
        private IGenerator _generator;

        [SetUp]
        public void Init()
        {
            _generator = new SequenceGenerator();
        }

        [Test]
        public void Generate_Should_Retun_Fizz_When_Number_Is_A_Multiple_Of_3_But_Does_Not_Contain_3()
        {
            var result = _generator.Generate(10);
            result.ElementAt(8).Should().Be("fizz");
        }

        [Test]
        public void Generate_Should_Retun_Buzz_When_Number_Is_A_Multiple_Of_5()
        {
            var result = _generator.Generate(5);
            result.ElementAt(4).Should().Be("buzz");
        }

        [Test]
        public void Generate_Should_Retun_FizzBuzz_When_Number_Is_A_Multiple_Of_15()
        {
            var result = _generator.Generate(15);
            result.ElementAt(14).Should().Be("fizzbuzz");
        }

        [Test]
        public void Generate_Should_Not_Retun_FizzBuzz_When_Number_Is_A_Multiple_Of_Five_Only()
        {
            var result = _generator.Generate(15);
            result.ElementAt(4).Should().NotBe("fizzbuzz");
        }

        [Test]
        public void Generate_Should_Not_Retun_FizzBuzz_When_Number_Is_A_Multiple_Of_Three_Only()
        {
            var result = _generator.Generate(3);
            result.ElementAt(2).Should().NotBe("fizzbuzz");
        }

        [Test]
        public void Generate_Should_Not_Retun_Fizz_When_Number_Is_A_Multiple_Of_15()
        {
            var result = _generator.Generate(15);
            result.ElementAt(14).Should().NotBe("fizz");
        }

        [Test]
        public void Generate_Should_Not_Retun_Buzz_When_Number_Is_A_Multiple_Of_15()
        {
            var result = _generator.Generate(15);
            result.ElementAt(14).Should().NotBe("buzz");
        }

        [Test]
        public void Generate_Should_Retun_Int_Number_When_Number_Is_Not_5_Or_3_Mupltiple()
        {
            var result = _generator.Generate(5);
            result.ElementAt(0).Should().Be("1");
            result.ElementAt(1).Should().Be("2");
            result.ElementAt(3).Should().Be("4");
        }

        [Test]
        public void Generate_Should_Retun_A_Comlpete_Set_When_A_Positive_Limit_Is_Given()
        {
            var result = _generator.Generate(5);
            result.Count.Should().Be(5);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void Generate_Should_Retun_An_Empty_Set_When_An_Invalid_Limit_Is_Given(int limit)
        {
            var result = _generator.Generate(limit);
            result.Count.Should().Be(0);
        }

        [TestCase(2)]
        [TestCase(12)]
        public void Generate_Should_Retun_Lucky_When_Number_Contains_Three_On_Possition(int possition)
        {
            var result = _generator.Generate(15);
            result.ElementAt(possition).Should().Be("lucky");
        }

        [TestCase(2)]
        [TestCase(32)]
        public void Generate_Should_Not_Retun_Fizz_When_Number_Contains_Three_And_Is_Multiple_of_Three_On_Possition(int possition)
        {
            var result = _generator.Generate(35);
            result.ElementAt(possition).Should().NotBe("fizz");
        }
    }
}
