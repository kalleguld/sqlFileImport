

using System.IO;
using System.Text;
using Xunit;

namespace UnitTest{
    public class Sql
    {
        public class NormChar
        {
            [Fact]
            public void doubleQuote()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\NormChar\doubleQuote.sql", Encoding.UTF8),
                    qlt2.Sql.NormChar.doubleQuote);
            }
            [Fact]
            public void newline()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\NormChar\newline.sql", Encoding.UTF8),
                    qlt2.Sql.NormChar.newline);
            }
            [Fact]
            public void normal()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\NormChar\normal.sql", Encoding.UTF8),
                    qlt2.Sql.NormChar.normal);
            }
            [Fact]
            public void singleQuote()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\NormChar\singleQuote.sql", Encoding.UTF8),
                    qlt2.Sql.NormChar.singleQuote);
            }
        }

        public class u16
        {
            [Fact]
            public void doubleQuote()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\u16\doubleQuote.sql", Encoding.UTF8),
                    qlt2.Sql.u16.doubleQuote);
            }
            [Fact]
            public void newline()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\u16\newline.sql", Encoding.UTF8),
                    qlt2.Sql.u16.newline);
            }
            [Fact]
            public void singleQuote()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\u16\singleQuote.sql", Encoding.UTF8),
                    qlt2.Sql.u16.singleQuote);
            }
        }

        public class u32
        {
            [Fact]
            public void doubleQuote()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\u32\doubleQuote.sql", Encoding.UTF8),
                    qlt2.Sql.u32.doubleQuote);
            }
            [Fact]
            public void newline()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\u32\newline.sql", Encoding.UTF8),
                    qlt2.Sql.u32.newline);
            }
            [Fact]
            public void singleQuote()
            {
                Assert.Equal(
                    File.ReadAllText(@"C:\Users\kalleguld\Source\Repos\SqlFileTest\UnitTest\../qlt2/Sql\u32\singleQuote.sql", Encoding.UTF8),
                    qlt2.Sql.u32.singleQuote);
            }
        }

    }

}

