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

    public partial class Form1 : Form
    {
        //string[] questions = { "Question1", "Question2", "Question3" };
        //label1.Text = questions[0];
        //label2.Text = questions[1];
        //label3.Text = questions[2];

        //string[] answers = { "Answers1", "Answers2", "Answers3", };
        public Form1()
        {
            InitializeComponent();
            btnNext.Visible = false;
            correctText.Visible = false;
        }
        public int correct = 0;
        public int wrong= 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Question c = new Question();
            lblQuestion.Text = c.f1[0];
            choice1.Text = c.f1[1];
            choice2.Text = c.f1[2];
            choice3.Text = c.f1[3];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            correctText.Visible = true;
            btnNext.Visible = true;
            if (choice1.Checked || choice2.Checked || choice3.Checked)
            {
                if (choice1.Checked)
                {
                    correct++;
                    correctText.Text = "Correct answer";
                    correctText.BackColor = Color.Green;
                }
                else{
                    wrong++;
                    correctText.Text = "Wrong answer ";
                    correctText.BackColor = Color.Red;
                }
            }
            choice1.Enabled = false;
            choice2.Enabled = false;
            choice3.Enabled = false;
            button1.Enabled= false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2();
            form.correct = correct;
            form.wrong = wrong;
            form.Show();
            this.Hide();
        }

       
    }
}
