
namespace Quiz
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.choice3 = new System.Windows.Forms.RadioButton();
            this.choice2 = new System.Windows.Forms.RadioButton();
            this.choice1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWrong = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnChoice = new System.Windows.Forms.Button();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.choice3);
            this.panel1.Controls.Add(this.choice2);
            this.panel1.Controls.Add(this.choice1);
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.panel1.Location = new System.Drawing.Point(108, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 245);
            this.panel1.TabIndex = 5;
            // 
            // choice3
            // 
            this.choice3.AutoSize = true;
            this.choice3.Location = new System.Drawing.Point(14, 154);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(133, 28);
            this.choice3.TabIndex = 3;
            this.choice3.TabStop = true;
            this.choice3.Text = "radioButton3";
            this.choice3.UseVisualStyleBackColor = true;
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.Location = new System.Drawing.Point(14, 115);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(133, 28);
            this.choice2.TabIndex = 2;
            this.choice2.TabStop = true;
            this.choice2.Text = "radioButton2";
            this.choice2.UseVisualStyleBackColor = true;
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.Location = new System.Drawing.Point(14, 75);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(133, 28);
            this.choice1.TabIndex = 1;
            this.choice1.TabStop = true;
            this.choice1.Text = "radioButton1";
            this.choice1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(101, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question...";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.lblWrong);
            this.panel4.Controls.Add(this.lblCorrect);
            this.panel4.Location = new System.Drawing.Point(521, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 133);
            this.panel4.TabIndex = 7;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Location = new System.Drawing.Point(46, 74);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(46, 17);
            this.lblWrong.TabIndex = 1;
            this.lblWrong.Text = "label5";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(46, 26);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(46, 17);
            this.lblCorrect.TabIndex = 0;
            this.lblCorrect.Text = "label4";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFinish.Location = new System.Drawing.Point(643, 359);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(116, 38);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChoice
            // 
            this.btnChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnChoice.Location = new System.Drawing.Point(256, 284);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(123, 70);
            this.btnChoice.TabIndex = 9;
            this.btnChoice.Text = "Choice";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CorrectLabel.Location = new System.Drawing.Point(491, 108);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(0, 24);
            this.CorrectLabel.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton choice3;
        private System.Windows.Forms.RadioButton choice2;
        private System.Windows.Forms.RadioButton choice1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Label CorrectLabel;
    }
}