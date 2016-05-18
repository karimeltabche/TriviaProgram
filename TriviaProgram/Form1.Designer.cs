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
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 18);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(521, 33);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbAnswer1
            // 
            this.rdbAnswer1.AutoSize = true;
            this.rdbAnswer1.Location = new System.Drawing.Point(36, 83);
            this.rdbAnswer1.Name = "rdbAnswer1";
            this.rdbAnswer1.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer1.TabIndex = 0;
            this.rdbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer2
            // 
            this.rdbAnswer2.AutoSize = true;
            this.rdbAnswer2.Location = new System.Drawing.Point(36, 120);
            this.rdbAnswer2.Name = "rdbAnswer2";
            this.rdbAnswer2.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer2.TabIndex = 1;
            this.rdbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer3
            // 
            this.rdbAnswer3.AutoSize = true;
            this.rdbAnswer3.Location = new System.Drawing.Point(36, 157);
            this.rdbAnswer3.Name = "rdbAnswer3";
            this.rdbAnswer3.Size = new System.Drawing.Size(14, 13);
            this.rdbAnswer3.TabIndex = 2;
            this.rdbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer4
            // 
            this.rdbAnswer4.AutoSize = true;
            this.rdbAnswer4.Location = new System.Drawing.Point(36, 194);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.Location = new System.Drawing.Point(167, 252);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(23, 23);
            this.lblCorrect.TabIndex = 7;
            // 
            // lblWrong
            // 
            this.lblWrong.Location = new System.Drawing.Point(309, 252);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(23, 23);
            this.lblWrong.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Correct answers: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wrong answers: ";
            // 
            // frmTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdbAnswer4);
            this.Controls.Add(this.rdbAnswer3);
            this.Controls.Add(this.rdbAnswer2);
            this.Controls.Add(this.rdbAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmTrivia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

