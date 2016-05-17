namespace TriviaProgram
{
    partial class frmTrivia
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lnkScore = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Location = new System.Drawing.Point(47, 40);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(364, 23);
            this.lblQuestion.TabIndex = 0;
            // 
            // rdbAnswer1
            // 
            this.rdbAnswer1.AutoSize = true;
            this.rdbAnswer1.Location = new System.Drawing.Point(47, 97);
            this.rdbAnswer1.Name = "rdbAnswer1";
            this.rdbAnswer1.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer1.TabIndex = 0;
            this.rdbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer2
            // 
            this.rdbAnswer2.AutoSize = true;
            this.rdbAnswer2.Location = new System.Drawing.Point(47, 134);
            this.rdbAnswer2.Name = "rdbAnswer2";
            this.rdbAnswer2.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer2.TabIndex = 1;
            this.rdbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer3
            // 
            this.rdbAnswer3.AutoSize = true;
            this.rdbAnswer3.Location = new System.Drawing.Point(47, 171);
            this.rdbAnswer3.Name = "rdbAnswer3";
            this.rdbAnswer3.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer3.TabIndex = 2;
            this.rdbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer4
            // 
            this.rdbAnswer4.AutoSize = true;
            this.rdbAnswer4.Location = new System.Drawing.Point(47, 208);
            this.rdbAnswer4.Name = "rdbAnswer4";
            this.rdbAnswer4.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer4.TabIndex = 3;
            this.rdbAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(458, 225);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(458, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lnkScore
            // 
            this.lnkScore.AutoSize = true;
            this.lnkScore.Location = new System.Drawing.Point(478, 13);
            this.lnkScore.Name = "lnkScore";
            this.lnkScore.Size = new System.Drawing.Size(61, 13);
            this.lnkScore.TabIndex = 6;
            this.lnkScore.TabStop = true;
            this.lnkScore.Text = "View Score";
            // 
            // frmTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 289);
            this.Controls.Add(this.lnkScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdbAnswer4);
            this.Controls.Add(this.rdbAnswer3);
            this.Controls.Add(this.rdbAnswer2);
            this.Controls.Add(this.rdbAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmTrivia";
            this.Text = "Trivia Program";
            this.Load += new System.EventHandler(this.frmTrivia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdbAnswer1;
        private System.Windows.Forms.RadioButton rdbAnswer2;
        private System.Windows.Forms.RadioButton rdbAnswer3;
        private System.Windows.Forms.RadioButton rdbAnswer4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnkScore;
    }
}

