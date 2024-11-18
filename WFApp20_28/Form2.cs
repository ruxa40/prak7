using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp19_20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }

        public string TextValue()
        {
            return textBox1.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog.Color;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog.Font;
        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                fs.Close();
            }
        }

        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += PrintPageHandler;
            printPreviewDialog.Document = printDocument;
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                printPreviewDialog.Document.Print();
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, Font, Brushes.Black, 20, 20);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти из программы ?", "Запрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Close();
        }
    }
}
