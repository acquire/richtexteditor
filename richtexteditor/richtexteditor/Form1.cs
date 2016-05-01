using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richtexteditor
{
    public partial class Form1 : Form
    {

        /*
        Feature list
        ------------
        Heading Style
        Prompt to capitalize sentences
        Dictionary
        Spell Check
        Title is filename
        show whitespace characters
        */

        /*
        bugs
        ----
        save cancel crashes program
        */

        string filename = "";

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //save
            //filename = Prompt.ShowDialog("Save", "Enter a filename", ".rtf");
            //richTextBox1.SaveFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + filename);

            //open
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ApplyStyle();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ApplyStyle();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ApplyStyle();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ApplyStyle();
        }

        void ApplyStyle()
        {
            FontStyle newStyle = FontStyle.Regular;
            if (toolStripButton3.Checked) { newStyle = FontStyle.Bold; }
            if (toolStripButton4.Checked) { newStyle = newStyle | FontStyle.Italic; }
            if (toolStripButton5.Checked) { newStyle = newStyle | FontStyle.Underline; }
            if (toolStripButton6.Checked) { newStyle = newStyle | FontStyle.Strikeout; }
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, newStyle);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size + 10, richTextBox1.SelectionFont.Style);
        }
    }
}
