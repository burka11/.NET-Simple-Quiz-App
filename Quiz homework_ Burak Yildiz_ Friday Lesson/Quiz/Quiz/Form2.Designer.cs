
namespace Quiz
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.choice3 = new System.Windows.Forms.RadioButton();
            this.choice2 = new System.Windows.Forms.RadioButton();
            this.choice1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnChoice = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.choice3);
            this.panel1.Controls.Add(this.choice2);
            this.panel1.Controls.Add(this.choice1);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Location = new System.Drawing.Point(96, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 262);
            this.panel1.TabIndex = 5;
            // 
            // choice3
            // 
            this.choice3.AutoSize = true;
            this.choice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.choice3.Location = new System.Drawing.Point(16, 142);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(14, 13);
            this.choice3.TabIndex = 3;
            this.choice3.TabStop = true;
            this.choice3.UseVisualStyleBackColor = true;
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.choice2.Location = new System.Drawing.Point(16, 108);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(14, 13);
            this.choice2.TabIndex = 2;
            this.choice2.TabStop = true;
            this.choice2.UseVisualStyleBackColor = true;
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.choice1.Location = new System.Drawing.Point(16, 74);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(14, 13);
            this.choice1.TabIndex = 1;
            this.choice1.TabStop = true;
            this.choice1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblQuestion.Location = new System.Drawing.Point(12, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // btnChoice
            // 
            this.btnChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnChoice.Location = new System.Drawing.Point(459, 313);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(123, 50);
            this.btnChoice.TabIndex = 7;
            this.btnChoice.Text = "Choice";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(789, 351);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 35);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(443, 108);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 17);
            this.lblCorrect.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 506);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.RadioButton choice3;
        private System.Windows.Forms.RadioButton choice2;
        private System.Windows.Forms.RadioButton choice1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCorrect;
    }
}