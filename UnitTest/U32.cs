using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest
{
    public class U32
    {
        [Fact]
        public void DoubleQuote()
        {
            Assert.Equal(
                "\"In double quotes \uD83D\uDD76\"",
                qlt2.Sql.u32.doubleQuote
                );
        }

        [Fact]
        public void SingleQuote()
        {
            Assert.Equal(
                "declare @a nvarchar(max) = 'in single quotes \uD83D\uDD76';",
                qlt2.Sql.u32.singleQuote
                );
        }

        [Fact]
        public void NewLine()
        {
            Assert.Equal(
                "line1" + "\r\n" + "line2" + "\r\n" + "\uD83D\uDD76",
                qlt2.Sql.u32.newline
                );
        }
    }
}
