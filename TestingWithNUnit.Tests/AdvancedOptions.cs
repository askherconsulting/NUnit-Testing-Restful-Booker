using System;
using FluentAssertions;
using NUnit.Framework;

namespace TestingWithNUnit.Tests
{
    [TestFixture]
    public class AdvancedOptions
    {

        [Test]
        public void UsingWarnings()
        {
            var isProcessed = false;
            Warn.Unless(isProcessed, Is.EqualTo(true)
                .After(1).Minutes.PollEvery(10).Seconds);
            Console.WriteLine("still going");
        }

        [Test]
        public void Assumptions()
        {
            Assume.That("a value", Is.EqualTo("a value"));
        }

        [Test]
        public void AssumingThenAsserting()
        {
            var customSettingEnabled = true;
            Assume.That(customSettingEnabled, Is.True);

            // test actions here...

            Assert.That("actual", Is.EqualTo("actual"));

        }

        [Test]
        public void AssertPassThrowsException()
        {
            Assert.That(Assert.Pass, Throws.TypeOf<SuccessException>());
        }

        [Test]
        public void WillThisMakeItThroughCodeReview()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, 1);
                Assert.AreEqual(2, 2);
            });
        }

        [Test]
        public void AssertingWithFluentAssertions()
        {
            "actual".Should().Be("actual");
        }








    }
}