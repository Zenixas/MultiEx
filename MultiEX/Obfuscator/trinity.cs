using System;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace MultiEX
{
    public class obfuscator2
    {
        public static void trinityobfuscation(string FileToObf)
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
                string contents = "<project outputDir=\"" + path + "\" baseDir=\"" + path + "\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"copy.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>";
                File.WriteAllBytes(path + "\\Trinity.zip", Properties.Resources.Trinity);
                ZipFile.ExtractToDirectory(path + "\\Trinity.zip", path + "\\Trinity");
                File.WriteAllText(path + "\\Trinity\\trinityproj.crproj", contents);
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "/CConfuser.CLI trinityproj.crproj",
                    WorkingDirectory = path + "\\Trinity"
                };
                process.Start();
                process.WaitForExit();

                foreach (string file in Directory.GetFiles(path + "\\Trinity"))
                    File.Delete(file);
                Directory.Delete(path + "\\Trinity");
                File.Delete(path + "\\Trinity.zip");

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