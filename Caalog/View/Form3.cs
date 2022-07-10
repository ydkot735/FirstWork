using Caalog.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caalog.View
{
    public partial class Form3 : Form
    {
        String path;
        StreamReader sr;
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                path = OpenDlg.FileName;
            }
            richTextBox1.Text = path;
            sr = new StreamReader(path, System.Text.Encoding.Default);


        }
        private void start_prog_Click(object sender, EventArgs e)
        {
            TCatalog phone1 = new TCatalog(sr,path);
            richTextBox1.Text = phone1.ShowCatalog();
            richTextBox2.Text = phone1.ShowMaxMin();
            richTextBox3.Text = phone1.ShowRAMList();
            richTextBox1.Text = phone1.ShowMedprice();
            richTextBox1.Text = phone1.ShowColorList();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void back_label_form3_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0];
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.WriteLine(richTextBox2.Text);
                streamWriter.WriteLine("Список телефонов по ОЗУ");
                streamWriter.WriteLine(richTextBox3.Text);
                streamWriter.Close();
            }
        }
    }
}
