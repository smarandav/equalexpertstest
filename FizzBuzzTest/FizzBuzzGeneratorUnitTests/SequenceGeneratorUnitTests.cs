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
            result.SequenceNumbers.ElementAt(8).Should().Be("fizz");
        }

        [Test]
        public void Generate_Should_Retun_Buzz_When_Number_Is_A_Multiple_Of_5()
        {
            var result = _generator.Generate(5);
            result.SequenceNumbers.ElementAt(4).Should().Be("buzz");
        }

        [Test]
        public void Generate_Should_Retun_FizzBuzz_When_Number_Is_A_Multiple_Of_15()
        {
            var result = _generator.Generate(15);
            result.SequenceNumbers.ElementAt(14).Should().Be("fizzbuzz");
        }

        [Test]
        public void Generate_Should_Not_Retun_FizzBuzz_When_Number_Is_A_Multiple_Of_Five_Only()
        {
            var result = _generator.Generate(15);
            result.SequenceNumbers.ElementAt(4).Should().NotBe("fizzbuzz");
        }

        [Test]
        public void Generate_Should_Not_Retun_FizzBuzz_When_Number_Is_A_Multiple_Of_Three_Only()
        {
            var result = _generator.Generate(3);
            result.SequenceNumbers.ElementAt(2).Should().NotBe("fizzbuzz");
        }

        [Test]
        public void Generate_Should_Not_Retun_Fizz_When_Number_Is_A_Multiple_Of_15()
        {
            var result = _generator.Generate(15);
            result.SequenceNumbers.ElementAt(14).Should().NotBe("fizz");
        }

        [Test]
        public void Generate_Should_Not_Retun_Buzz_When_Number_Is_A_Multiple_Of_15()
        {
            var result = _generator.Generate(15);
            result.SequenceNumbers.ElementAt(14).Should().NotBe("buzz");
        }

        [Test]
        public void Generate_Should_Retun_Int_Number_When_Number_Is_Not_5_Or_3_Mupltiple()
        {
            var result = _generator.Generate(5);
            result.SequenceNumbers.ElementAt(0).Should().Be("1");
            result.SequenceNumbers.ElementAt(1).Should().Be("2");
            result.SequenceNumbers.ElementAt(3).Should().Be("4");
        }

        [Test]
        public void Generate_Should_Retun_A_Comlpete_Set_When_A_Positive_Limit_Is_Given()
        {
            var result = _generator.Generate(5);
            result.SequenceNumbers.Count.Should().Be(5);
        }

        [TestCase(-1)]
        [TestCase(0)]
        public void Generate_Should_Retun_An_Empty_Set_When_An_Invalid_Limit_Is_Given(int limit)
        {
            var result = _generator.Generate(limit);
            result.SequenceNumbers.Count.Should().Be(0);
        }

        [TestCase(2)]
        [TestCase(12)]
        public void Generate_Should_Retun_Lucky_When_Number_Contains_Three_On_Possition(int possition)
        {
            var result = _generator.Generate(15);
            result.SequenceNumbers.ElementAt(possition).Should().Be("lucky");
        }

        [TestCase(2)]
        [TestCase(32)]
        public void Generate_Should_Not_Retun_Fizz_When_Number_Contains_Three_And_Is_Multiple_of_Three_On_Possition(int possition)
        {
            var result = _generator.Generate(35);
            result.SequenceNumbers.ElementAt(possition).Should().NotBe("fizz");
        }

        [TestCase("fizz", 4)]
        [TestCase("buzz", 3)]
        [TestCase("fizzbuzz", 1)]
        [TestCase("lucky", 2)]
        [TestCase("integer", 10)]
        public void Generate_Should_Retun_FizzBuzzResult_With_SequenceCounts_When_Limit_Is_Positive(string key, int count)
        {
            var result = _generator.Generate(20);
            result.SequenceCounts[key].Should().Be(count);
        }

        [TestCase(-1, "fizz")]
        [TestCase(-1, "buzz")]
        [TestCase(-1, "fizzbuzz")]
        [TestCase(-1, "lucky")]
        [TestCase(-1, "integer")]
        [TestCase(0, "fizz")]
        [TestCase(0, "buzz")]
        [TestCase(0, "fizzbuzz")]
        [TestCase(0, "lucky")]
        [TestCase(0, "integer")]
        public void Generate_Should_Retun_FizzBuzzResult_With_SequenceCounts_With_Zero_Values_When_Limit_Is_Negative_Or_Zero(int limit, string key)
        {
            var result = _generator.Generate(limit);
            result.SequenceCounts[key].Should().Be(0);
        }
    }
}
