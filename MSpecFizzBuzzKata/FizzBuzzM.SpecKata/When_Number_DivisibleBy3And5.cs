using FluentAssertions;
using Machine.Specifications;
using Machine.Specifications.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSpectationLesson1
{
    [Subject("Given natural number of 1")]
    public class When_Number_IsNatural
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

            };
        Because of = () => Actual = Subject.FizzBuzz(1);

        It Should_Return_The_Input_Value_As_It_Is = () =>
        {
            Actual.Should().Be("1");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given Numbers divisible by 3")]
    public class When_Number_DivisibleBy3
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzBuzz(9);

        It Should_Have_Response_Of_Fizz = () =>
        {
            Actual.Should().Be("FizzBuzz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given Numbers divisible by 5")]
    public class When_Number_DivisibleBy5
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzBuzz(20);

        It Should_Have_Response_Of_Buzz = () =>
        {
            Actual.Should().Be("Buzz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given Numbers divisible by 5 And 3")]
    public class When_Number_DivisibleByBoth3And5
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzBuzz(75);

        It Should_Have_Response_FizzBuzz = () =>
        {
            Actual.Should().Be("FizzBuzz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given natural number of 4")]
    public class When_Number_IsNaturalPrime
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzWhiz(4);

        It Should_Return_The_Input_Value_As_It_Is = () =>
        {
            Actual.Should().Be("4");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given prime number")]
    public class When_Number_Is_A_Prime
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzWhiz(2);

        It Should_Return_Whiz = () =>
        {
            Actual.Should().Be("Whiz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given prime number divisible by 3")]
    public class When_Number_IsPrime_And_Divisible_By_3
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzWhiz(3);

        It Should_Have_Response_FizzWhiz = () =>
        {
            Actual.Should().Be("FizzWhiz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given prime number divisible by 5")]
    public class When_Number_IsPrime_And_Divisible_By_5
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.FizzWhiz(5);

        It Should_Have_Response_BuzzWhiz = () =>
        {
            Actual.Should().Be("BuzzWhiz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }
   
}
