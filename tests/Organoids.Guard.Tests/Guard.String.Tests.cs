using System;
using Xunit;

namespace Organoids.Guard.Tests
{
    public class StringGuardTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("        ")]
        public void NotEmptyOrWhiteSpace(string value)
        {
            Assert.Throws<ArgumentException>(() => Guard.String.NotEmptyOrWhiteSpace(value, nameof(value)));
        }

        [Theory]
        [InlineData("1", 0)]
        [InlineData("1", -1)]
        [InlineData("Lorem", 3)]
        [InlineData("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", 10)]
        public void MaxLength(string value, int maxLength)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.String.MaxLength(value, maxLength, nameof(value)));
        }
    }
}
