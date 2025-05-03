using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form6 frm6 = new Form6();
                frm6.Show();
                this.Hide();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Welcome sign
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            //logo
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
        }
    }
}
