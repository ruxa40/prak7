using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp20_28
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_wallpaper__1_DataSet.Обои". При необходимости она может быть перемещена или удалена.
            this.обоиTableAdapter.Fill(this._wallpaper__1_DataSet.Обои);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_wallpaper__1_DataSet.заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this._wallpaper__1_DataSet.заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыBindingSource.EndEdit();
            заказыTableAdapter.Update(_wallpaper__1_DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            обоиBindingSource.EndEdit();
            обоиTableAdapter.Update(_wallpaper__1_DataSet);
        }
    }
}
