using FluentAssertions;
using Machine.Specifications;
using Machine.Specifications.Model;
using NUnit.Framework;
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
        Because of = () => Actual = Subject.Fizz(1);

        It Should_Have_No_Response = () =>
        {
            Actual.Should().Be("1");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given natural number of 2")]
    public class When_Number_Is_A_Natural
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.Fizz(2);

        It Should_Have_No_Response = () =>
        {
            Actual.Should().Be("Whiz");
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
        Because of = () => Actual = Subject.Fizz(9);

        It Should_Have_No_Response = () =>
        {
            Actual.Should().Be("Fizz");
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
        Because of = () => Actual = Subject.Fizz(20);

        It Should_Have_No_Response = () =>
        {
            Actual.Should().Be("Buzz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

    [Subject("Given Numbers divisible by 5")]
    public class When_Number_DivisibleByBoth3And5
    {
        Establish context = () => {
            Subject = new FizzBuzzer();

        };
        Because of = () => Actual = Subject.Fizz(75);

        It Should_Have_No_Response = () =>
        {
            Actual.Should().Be("FizzBuzz");
        };

        static FizzBuzzer Subject;
        static string Actual;
    }

}
