using Caalog.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Info_Label_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
        private void Start_Label_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
        private void Exit_Label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Start_Label_MouseHover(object sender, EventArgs e)
        {
            Start_Label.Font = new Font(Start_Label.Font, FontStyle.Underline | FontStyle.Bold);

        }
        private void Start_Label_MouseLeave(object sender, EventArgs e)
        {
            Start_Label.Font = new Font(Start_Label.Font, FontStyle.Bold);
        }
        private void Info_Label_MouseHover(object sender, EventArgs e)
        {
            Info_Label.Font = new Font(Info_Label.Font, FontStyle.Underline | FontStyle.Bold);
        }
        private void Info_Label_MouseLeave(object sender, EventArgs e)
        {
            Info_Label.Font = new Font(Info_Label.Font, FontStyle.Bold);
        }
        private void Exit_Label_MouseHover(object sender, EventArgs e)
        {
            Exit_Label.Font = new Font(Exit_Label.Font, FontStyle.Underline | FontStyle.Bold);
        }
        private void Exit_Label_MouseLeave(object sender, EventArgs e)
        {
            Exit_Label.Font = new Font(Exit_Label.Font, FontStyle.Bold);
        }
    }
}
