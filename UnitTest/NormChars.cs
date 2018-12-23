using System;
using Xunit;

namespace UnitTest
{
    public class NormChars
    {
        [Fact]
        public void DoubleQuote()
        {
            Assert.Equal(
                "\"In double quotes\"",
                qlt2.Sql.NormChar.doubleQuote
                );
        }

        [Fact]
        public void SingleQuote()
        {
            Assert.Equal(
                "declare @a nvarchar(max) = 'in single quotes';",
                qlt2.Sql.NormChar.singleQuote
                );
        }

        [Fact]
        public void NewLine()
        {
            Assert.Equal(
                "line1" + "\r\n" + "line2",
                qlt2.Sql.NormChar.newline
                );
        }
        
    }
}
