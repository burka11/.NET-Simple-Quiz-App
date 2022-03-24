using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int correct;
        public int wrong;

        private void Form2_Load(object sender, EventArgs e)
        {
            Question c = new Question();
            lblQuestion.Text = c.f2[0];
            choice1.Text = c.f2[1];
            choice2.Text = c.f2[2];
            choice3.Text = c.f2[3];
            btnNext.Visible = false;
            lblCorrect.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCorrect.Visible = true;
            btnNext.Visible = true;
            if (choice1.Checked || choice2.Checked || choice3.Checked)
            {

                if (choice1.Checked)
                {
                    correct++;
                    lblCorrect.Text = "Correct answer";
                    lblCorrect.BackColor = Color.Green;
                }
                else
                {
                    wrong++;
                    lblCorrect.Text = "Wrong answer ";
                    lblCorrect.BackColor = Color.Red;
                }
            }
            btnChoice.Enabled = false;
            choice1.Enabled = false;
            choice2.Enabled = false;
            choice3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.correct = correct;
            f.wrong = wrong;
            f.Show();
            this.Hide();
        }
    }
}
