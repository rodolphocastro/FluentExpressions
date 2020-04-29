using System;

using AutoFixture.Xunit2;

using FluentAssertions;

using FluentExpressions.Core.Tokens;

using Xunit;

namespace Tests.Core.Tokens
{
    public class MyToken : BaseToken
    {
        public MyToken(string value) : base(value)
        {
        }
    }

    public class BaseTokenTests
    {
        [Fact]
        public void Construct_EmptyValue_ArgumentException()
        {
            // Arrange
            // Act
            Action act = () => _ = new MyToken(string.Empty);

            // Assert
            act.Should().Throw<ArgumentException>();
        }

        [Theory, AutoData]
        public void GetValue([Frozen] string expected, MyToken subject)
        {
            // Arrange
            // Act
            string result = subject.Value;

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Theory, AutoData]
        public void ToString_Returns_Value(MyToken subject)
        {
            // Arrange
            // Act
            string result = subject.ToString();

            // Assert
            result.Should().BeEquivalentTo(subject.Value);
        }

        [Theory, AutoData]
        public void EqualsToken(MyToken subject)
        {
            // Arrange
            var copy = new MyToken(subject.Value);
            // Act
            bool result = copy.Equals(subject);

            // Assert
            copy.Should().BeEquivalentTo(subject);
            result.Should().BeTrue();
        }

        [Theory, AutoData]
        public void Theory(MyToken subject)
        {
            // Arrange
            // Act
            string result = subject;

            // Assert
            result.Should().BeEquivalentTo(subject.Value);
        }
    }
}
