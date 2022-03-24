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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            btnFinish.Visible = false;
        }
        public int correct;
        public int wrong;
        private void Form3_Load(object sender, EventArgs e)
        {
            Question c = new Question();
            lblQuestion.Text = c.f3[0];
            choice1.Text = c.f3[1];
            choice2.Text = c.f3[2];
            choice3.Text = c.f3[3];
            panel4.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choice1.Checked || choice2.Checked || choice3.Checked)
            {

                if (choice1.Checked)
                {
                    correct++;
                    lblCorrect.Text = "Correct answer";
                    CorrectLabel.Text = "Correct answer";
                    CorrectLabel.BackColor = Color.Green;
                }
                else
                {
                    wrong++;
                    lblWrong.Text = "Wrong answer ";
                    CorrectLabel.Text = "Wrong answerr";
                    CorrectLabel.BackColor = Color.Red;
                }
            }
            btnChoice.Enabled = false;
            choice1.Enabled = false;
            choice2.Enabled = false;
            choice3.Enabled = false;

            lblCorrect.Text = "Total Correct answers : "+ correct.ToString();
            lblCorrect.BackColor = Color.Green;
            lblWrong.Text = "Total Wrong answers : "+ wrong.ToString();
            lblWrong.BackColor = Color.Red;
            btnFinish.Visible = true;

            panel4.Visible = true;
        }

    }
}
