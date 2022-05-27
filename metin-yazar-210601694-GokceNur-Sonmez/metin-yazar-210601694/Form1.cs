using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metin_yazar_210601694
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            stackll CumleLer = new stackll();
            stackll Kelimeler = new stackll();
            heap Heap = new heap();
            OpenFileDialog belge = new OpenFileDialog();
            TxtDosya.Text = belge.FileName;
            belge.ShowDialog();
        }

        private void btnKelimeleriGoster_Click(object sender, EventArgs e)
        {

        }

        private void buttonStack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
