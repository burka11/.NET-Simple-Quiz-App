
namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.RadioButton();
            this.choice2 = new System.Windows.Forms.RadioButton();
            this.choice3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.correctText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.OrangeRed;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblQuestion.Location = new System.Drawing.Point(132, 84);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 24);
            this.lblQuestion.TabIndex = 0;
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.BackColor = System.Drawing.Color.OrangeRed;
            this.choice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.choice1.Location = new System.Drawing.Point(135, 115);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(133, 28);
            this.choice1.TabIndex = 1;
            this.choice1.TabStop = true;
            this.choice1.Text = "radioButton1";
            this.choice1.UseVisualStyleBackColor = false;
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.BackColor = System.Drawing.Color.OrangeRed;
            this.choice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.choice2.Location = new System.Drawing.Point(136, 149);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(133, 28);
            this.choice2.TabIndex = 2;
            this.choice2.TabStop = true;
            this.choice2.Text = "radioButton2";
            this.choice2.UseVisualStyleBackColor = false;
            // 
            // choice3
            // 
            this.choice3.AutoSize = true;
            this.choice3.BackColor = System.Drawing.Color.OrangeRed;
            this.choice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.choice3.Location = new System.Drawing.Point(136, 183);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(133, 28);
            this.choice3.TabIndex = 3;
            this.choice3.TabStop = true;
            this.choice3.Text = "radioButton3";
            this.choice3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(304, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Choice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNext.Location = new System.Drawing.Point(651, 356);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 45);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // correctText
            // 
            this.correctText.AutoSize = true;
            this.correctText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.correctText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.correctText.Location = new System.Drawing.Point(509, 141);
            this.correctText.Name = "correctText";
            this.correctText.Size = new System.Drawing.Size(75, 24);
            this.correctText.TabIndex = 9;
            this.correctText.Text = "Choice ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.correctText);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton choice3;
        private System.Windows.Forms.RadioButton choice2;
        private System.Windows.Forms.RadioButton choice1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label correctText;
    }
}

