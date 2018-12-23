using System;
using Xunit;

namespace UnitTest
{
    public class SpecialChars
    {
        [Fact]
        public void DoubleQuote()
        {
            Assert.Equal(
                "\"In double quotes\"",
                qlt2.Sql.doubleQuote
                );
        }

        [Fact]
        public void SingleQuote()
        {
            Assert.Equal(
                "declare @a nvarchar(max) = 'in single quotes';",
                qlt2.Sql.singleQuote
                );
        }

        [Fact]
        public void NewLine()
        {
            Assert.Equal(
                "line1" + "\r\n" + "line2",
                qlt2.Sql.newline
                );
        }

        [Fact]
        public void ExtChar()
        {
            Assert.Equal(
                "declare @emoji nvarchar(max) = '\uD83D\uDD76'",
                qlt2.Sql.extChar
                );
        }
    }
}
