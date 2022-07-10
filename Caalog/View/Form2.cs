using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caalog.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Label_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0]; 
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }
    }
}
