using System;
using System.Windows.Forms;

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
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Checked = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            #region SkidzexObfuscator

            if (checkBox1.Checked) obfuscator1.skidzexobfuscation(textBox1.Text);

            #endregion

            #region TrinityObfuscator

            if (checkBox2.Checked) obfuscator2.trinityobfuscation(textBox1.Text);

            #endregion

            #region Beds

            if (checkBox3.Checked) obfuscator3.bedsobfuscation(textBox1.Text);

            #endregion

            #region Neo

            if (checkBox4.Checked) obfuscator4.neoobfuscation(textBox1.Text);

            #endregion
        }
    }
}