using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.CodeDom.Compiler;
using System.Threading;


using Microsoft.CSharp;


using System.Collections;
using System.Diagnostics;


namespace MultiEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executables | *.*";
            openFileDialog.ShowDialog();
            textBox1.Text = openFileDialog.FileName;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                /*checkBox2.Checked = false;*/
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }
/*        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }*/

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                /*checkBox2.Checked = false;*/
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            /*checkBox2.Checked = false;*/
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                /*checkBox2.Checked = false;*/
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Checked = false;
            }
        }

/*        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Checked = false;
                checkBox5.Checked = false;
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            #region SkiDzEX
            if (checkBox1.Checked == true)
            {
                string zenas = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + "copy" + ".exe";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Executables | *.*";
                saveFileDialog.ShowDialog();
                string saveris = saveFileDialog.FileName;

                File.Copy(Path.Combine(textBox1.Text), Path.Combine(zenas));
                string path = Environment.ExpandEnvironmentVariables("%TEMP%");
                string contents = "<project outputDir=\"" + path + "\" baseDir=\"" + path + "\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"copy.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>";
                File.WriteAllBytes(path + "\\SkiDzEX.zip", Properties.Resources.SkiDzEX);
                ZipFile.ExtractToDirectory(path + "\\SkiDzEX.zip", path + "\\SkiDzEX");
                File.WriteAllText(path + "\\SkiDzEX\\trinityproj.crproj", contents);
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "/CConfuser.CLI trinityproj.crproj",
                    WorkingDirectory = path + "\\SkiDzEX"
                };
                process.Start();
                process.WaitForExit();
                
                foreach (string file in Directory.GetFiles(path + "\\SkiDzEX"))
                File.Delete(file);
                Directory.Delete(path + "\\SkiDzEX");
                File.Delete(path + "\\SkiDzEX.zip");

                File.Move(Path.Combine(zenas), Path.Combine(saveris + ".exe"));
            }
            #endregion


            #region Beds
            if (checkBox3.Checked == true)
            {
                string zenas = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + "copy" + ".exe";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Executables | *.*";
                saveFileDialog.ShowDialog();
                string saveris = saveFileDialog.FileName;

                File.Copy(Path.Combine(textBox1.Text), Path.Combine(zenas));
                string path = Environment.ExpandEnvironmentVariables("%TEMP%");
                string contents = "<project outputDir=\"" + path + "\" baseDir=\"" + path + "\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"copy.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>";
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
            #endregion

            #region Neo
            if (checkBox4.Checked == true)
            {
                string zenas = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + "copy" + ".exe";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Executables | *.*";
                saveFileDialog.ShowDialog();
                string saveris = saveFileDialog.FileName;

                File.Copy(Path.Combine(textBox1.Text), Path.Combine(zenas));
                string path = Environment.ExpandEnvironmentVariables("%TEMP%");
                string contents = "<project outputDir=\"" + path + "\" baseDir=\"" + path + "\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"copy.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>";
                File.WriteAllBytes(path + "\\neo.zip", Properties.Resources.neo);
                ZipFile.ExtractToDirectory(path + "\\neo.zip", path + "\\neo");
                File.WriteAllText(path + "\\neo\\trinityproj.crproj", contents);
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "/CConfuser.CLI trinityproj.crproj",
                    WorkingDirectory = path + "\\neo"
                };
                process.Start();
                process.WaitForExit();

                foreach (string file in Directory.GetFiles(path + "\\neo"))
                    File.Delete(file);
                Directory.Delete(path + "\\neo");
                File.Delete(path + "\\neo.zip");

                File.Move(Path.Combine(zenas), Path.Combine(saveris + ".exe"));
            }
            #endregion

            #region Trinity
            if (checkBox5.Checked == true)
            {
                string zenas = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + "copy" + ".exe";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Executables | *.*";
                saveFileDialog.ShowDialog();
                string saveris = saveFileDialog.FileName;

                File.Copy(Path.Combine(textBox1.Text), Path.Combine(zenas));
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
            #endregion

        
        }


    }
}
