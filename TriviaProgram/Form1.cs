using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TriviaProgram
{

    public partial class frmTrivia : Form
    {
        string question, ans1, ans2, ans3, ans4;
        int ansChoose, ansCorrect, score;
        StreamReader inputFile = new StreamReader(@"questions.txt");


        public frmTrivia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrivia_Load(object sender, EventArgs e)
        {

           try
            {
                inputFile = File.OpenText(@"questions.txt");

                MessageBox.Show("File exist\n");
                question = inputFile.ReadLine();
                ans1 = inputFile.ReadLine();
                ans2 = inputFile.ReadLine();
                ans3 = inputFile.ReadLine();
                ans4 = inputFile.ReadLine();
                ansCorrect = Convert.ToInt32(inputFile.ReadLine());
                lblQuestion.Text = question.ToString();
                rdbAnswer1.Text = ans1.ToString();
                rdbAnswer2.Text = ans2.ToString();
                rdbAnswer3.Text = ans3.ToString();
                rdbAnswer4.Text = ans4.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show("File does not exist\n" + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdbAnswer1.Checked ==false && rdbAnswer2.Checked ==false && rdbAnswer3.Checked==false && rdbAnswer4.Checked ==false)
            {
                MessageBox.Show("Please choose an answer before proceeding");
            }
            else
            {
                if (rdbAnswer1.Checked)
                {
                    ansChoose = 1;
                }
                else if (rdbAnswer2.Checked)
                {
                    ansChoose = 2;
                }
                else if (rdbAnswer3.Checked)
                {
                    ansChoose = 3;
                }
                else if (rdbAnswer4.Checked)
                {
                    ansChoose = 4;
                }

                if (ansChoose == ansCorrect)
                {
                    ++score;
                    MessageBox.Show("Correct!");
                }
                else
                {
                    MessageBox.Show("Wrong!");
                }
                if (!inputFile.EndOfStream)
                {
                    question = inputFile.ReadLine();
                    ans1 = inputFile.ReadLine();
                    ans2 = inputFile.ReadLine();
                    ans3 = inputFile.ReadLine();
                    ans4 = inputFile.ReadLine();
                    ansCorrect = Convert.ToInt32(inputFile.ReadLine());
                    lblQuestion.Text = question.ToString();
                    rdbAnswer1.Text = ans1.ToString();
                    rdbAnswer2.Text = ans2.ToString();
                    rdbAnswer3.Text = ans3.ToString();
                    rdbAnswer4.Text = ans4.ToString();

                    
                }
                else
                {
                    inputFile.Close();

                }
            }

        }
    }
}
    

