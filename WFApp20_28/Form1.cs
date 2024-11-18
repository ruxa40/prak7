using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFApp20_28;

namespace WFApp19_20
{
    public partial class fmMain : Form
    {
        Form2 form2 = new Form2();
        AboutBox1 aboutBox1 = new AboutBox1();

        public fmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = form2.ShowDialog();
            if (res == DialogResult.OK)
                aboutBox1.SetText(form2.TextValue());
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutBox1.SetText(form2.TextValue());
            aboutBox1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы точно хотите выйти?",
                "Уточнение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button3,
                MessageBoxOptions.DefaultDesktopOnly);
            switch (result)
            {
                case DialogResult.Yes:
                    /////////////
                    // Действия необходимые перед закрытием формы
                    ////////////

                    Close();
                    break;
                case DialogResult.No:
                    /////////////
                    // Действия необходимые при отмене закрытия формы
                    ////////////
                    break;
            }
            

            this.TopMost = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }
    }
}
