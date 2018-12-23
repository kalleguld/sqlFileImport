using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTest
{
    public class ImportFiles
    {
        public string Qltr(string dirName, string constName, string indent)
        {
            var sb = new StringBuilder();

            sb.AppendLine(indent + "public class " + Path.GetFileName(dirName));
            sb.AppendLine(indent + "{");
            var ni = indent + "    ";

            foreach (var file in Directory.EnumerateFiles(dirName, "*.sql"))
            {

                sb.AppendLine(ni + "[Fact]");
                sb.AppendLine($"{ni}public void {Path.GetFileNameWithoutExtension(file)}()");
                sb.AppendLine(ni + "{");
                var nii = ni + "    ";
                sb.AppendLine($"{nii}Assert.Equal(");
                sb.AppendLine($"{nii}    File.ReadAllText(@\"{file}\", Encoding.UTF8),");
                sb.AppendLine($"{nii}    qlt2.{constName}.{Path.GetFileNameWithoutExtension(file)});");

                sb.AppendLine(ni + "}");
            }
            foreach (var subdir in Directory.EnumerateDirectories(dirName))
            {
                sb.AppendLine(Qltr(subdir, constName + "." + Path.GetFileName(subdir), ni));
            }
            sb.AppendLine(indent + "}");

            return sb.ToString();
        }
    }
}
