using FluentAssertions;

using FluentExpressions.Core.Tokens;

using Xunit;

namespace Tests.Core.Tokens
{
    public class AnchorTokenTests
    {
        [Fact]
        public void StartOfMatch()
        {
            // Arrange
            // Act
            var subject = AnchorToken.StartOfMatch;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._startOfMatch);
        }

        [Fact]
        public void String_Start()
        {
            // Arrange
            // Act
            var subject = AnchorToken.Strings.Start;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._startOfString);
        }

        [Fact]
        public void String_AltStart()
        {
            // Arrange
            // Act
            var subject = AnchorToken.Strings.AltStart;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._altStartOfString);
        }

        [Fact]
        public void String_End()
        {
            // Arrange
            // Act
            var subject = AnchorToken.Strings.End;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._endOfString);
        }

        [Fact]
        public void String_AltEnd()
        {
            // Arrange
            // Act
            var subject = AnchorToken.Strings.AltEnd;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._altEndOfString);
        }

        [Fact]
        public void String_AbsoluteEnd()
        {
            // Arrange
            // Act
            var subject = AnchorToken.Strings.AbsoluteEnd;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._absoluteEndOfString);
        }

        [Fact]
        public void Word()
        {
            // Arrange
            // Act
            var subject = AnchorToken.WordBoundary;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._wordBoundary);
        }

        [Fact]
        public void NonWord()
        {
            // Arrange
            // Act
            var subject = AnchorToken.NonWordBoundary;

            // Assert
            subject.Should()
                .BeOfType<AnchorToken>().And
                .BeAssignableTo<BaseToken>()
                .Which.Value.Should().BeEquivalentTo(AnchorConstants._nonWordBoundary);
        }
    }
}
