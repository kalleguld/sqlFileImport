using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest
{
    public class U16
    {
        [Fact]
        public void DoubleQuote()
        {
            Assert.Equal(
                "\"In double quotes ✔\"",
                qlt2.Sql.u16.doubleQuote
                );
        }

        [Fact]
        public void SingleQuote()
        {
            Assert.Equal(
                "declare @a nvarchar(max) = 'in single quotes ✔';",
                qlt2.Sql.u16.singleQuote
                );
        }

        [Fact]
        public void NewLine()
        {
            Assert.Equal(
                "line1" + "\r\n" + "line2" + "\r\n" + "✔",
                qlt2.Sql.u16.newline
                );
        }
    }
}
