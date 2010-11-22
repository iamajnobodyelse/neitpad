using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace neitpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Open.ShowDialog();
        }
            
        private void open_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamReader File = new System.IO.StreamReader(Open.FileName);
            string theText = File.ReadToEnd();
            File.Close();
            TextBox1.Text = theText;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save.ShowDialog();
        }

        private void save_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamWriter File = new System.IO.StreamWriter(Save.FileName, true);
            string theText = TextBox1.Text;
            File.WriteLine(theText);
            File.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font.ShowDialog();
            TextBox1.Font = Font.Font;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog(); 
        }


    }
}
