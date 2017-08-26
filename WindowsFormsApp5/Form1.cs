using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
       // var color = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        public Form1()
        {
            InitializeComponent();
        }
        string directory, icon, name, path;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directory = this.textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox2.Text == "" || textBox3.Text == "")
            {
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Please fill all the forms!!!";
            }
            else
            {


                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(directory, "autorun"));
                label4.Text = "";
                path = directory + "AUTORUN.inf";
                name = textBox3.Text;
                string destpath = System.IO.Path.Combine(directory, "autorun");
                destpath = System.IO.Path.Combine(destpath, name + ".ico");
                System.IO.File.Copy(icon, destpath, true);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine("[AutoRun]");
                    sw.Write("label=");
                    sw.WriteLine(name);
                    sw.Write("ICON=");
                    sw.Write("\\autorun");
                    sw.Write("\\");
                    sw.WriteLine( name + ".ico");
                    sw.Close();
               
                    MessageBox.Show("Icon Changed Successfully\nPlease remove and plugin the drive to see the changes");
                Application.Exit();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                icon = textBox2.Text = FD.FileName;
            }
        }
    }
}

