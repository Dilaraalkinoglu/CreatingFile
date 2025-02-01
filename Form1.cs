using System;
using System.Windows.Forms;


namespace Dosya_Klasor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Bir dosya se�in";
            openFileDialog1.Filter = "T�m Dosyalar|*.*|Metin Dosyalar�|*.txt|Resim Dosyalar�|*.jpg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog1.FileName;
                MessageBox.Show("Se�ilen Dosya: " + dosyaYolu);
            }
        }

        private void button2_Click(object sender, EventArgs e, SaveFileDialog saveFileDialog)
        {
            saveFileDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e,FolderBrowserDialog folderBrowserDialog)
        {
            folderBrowserDialog.ShowDialog();
        }
    }
}
