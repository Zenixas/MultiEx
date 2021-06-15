using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace MultiEX
{
    public class obfuscator3
    {
        public static void bedsobfuscation(string FileToObf)
        {
            try
            {
                string zenas = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + "copy" + ".exe";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Executables | *.*";
                saveFileDialog.ShowDialog();
                string saveris = saveFileDialog.FileName;

                File.Copy(Path.Combine(FileToObf), Path.Combine(zenas));
                string path = Environment.ExpandEnvironmentVariables("%TEMP%");
                string contents = "<project outputDir=\"" + path + "\" baseDir=\"" + path +
                                  "\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"copy.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>";
                File.WriteAllBytes(path + "\\BedsProtector.zip", Properties.Resources.BedsProtector);
                ZipFile.ExtractToDirectory(path + "\\BedsProtector.zip", path + "\\BedsProtector");
                File.WriteAllText(path + "\\BedsProtector\\trinityproj.crproj", contents);
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "/CConfuser.CLI trinityproj.crproj",
                    WorkingDirectory = path + "\\BedsProtector"
                };
                process.Start();
                process.WaitForExit();

                foreach (string file in Directory.GetFiles(path + "\\BedsProtector"))
                    File.Delete(file);
                Directory.Delete(path + "\\BedsProtector");
                File.Delete(path + "\\BedsProtector.zip");

                File.Move(Path.Combine(zenas), Path.Combine(saveris + ".exe"));
            }
            catch
            {
                MessageBox.Show("Obfuscation error");
                return;
            }

            MessageBox.Show("Obfuscation succes");
        }
    }
}