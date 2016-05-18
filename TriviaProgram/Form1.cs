/*=========================
FileName: TriviaProgram
FileType: Visual C#
Author: Karim El-Tabche
Created On: 5/15/2016 12:27:11 PM
Last Modified On: 5/17/2016 12:30:05 AM
Description: This is a quiz game that reads questions
             and answers from a file and display them 
             in a quiz format.
*/

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
        string question, ans1, ans2, ans3, ans4;    //Create variables that 
        int ansChoose, ansCorrect, score, wrongAns; //could be used throughout the form 
        StreamReader inputFile = new StreamReader(@"questions.txt");


        public frmTrivia()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTrivia_Load(object sender, EventArgs e)
        {

           try
            {
                inputFile = File.OpenText(@"questions.txt");//Open the text file on form load

                MessageBox.Show("File exist\n");//Displays a message if file is found on form load

                question = inputFile.ReadLine();//Reads question from file and stores it in a variable

                ans1 = inputFile.ReadLine();//////////////////////////////
                ans2 = inputFile.ReadLine();//Reads the answers from file
                ans3 = inputFile.ReadLine();//and stores them in variables
                ans4 = inputFile.ReadLine();//////////////////////////////

                ansCorrect = Convert.ToInt32(inputFile.ReadLine());//Stores correct answer by in a variable
                lblQuestion.Text = question.ToString();//Displays the first question on form load

                rdbAnswer1.Text = ans1.ToString();/////////////////////////////////
                rdbAnswer2.Text = ans2.ToString();//Displays the choices of 
                rdbAnswer3.Text = ans3.ToString();//the first question on form load
                rdbAnswer4.Text = ans4.ToString();//////////////////////////////////




            }
            catch (Exception ex)
            {
                MessageBox.Show("File does not exist\n" + ex.Message);//Displays file does not exist 
                                                                      //in a message box on form load
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbAnswer1.Checked == false && rdbAnswer2.Checked == false && 
                    rdbAnswer3.Checked == false && rdbAnswer4.Checked == false)
                {
                    MessageBox.Show("Please choose an answer before proceeding");
                    //Checks if any radio button if checked else it will not 
                    //proceed and will require to check a radio
                }
                else
                {
                    if (rdbAnswer1.Checked)
                    {
                        ansChoose = 1;
                    }                                       //
                    else if (rdbAnswer2.Checked)            //
                    {                                       //
                        ansChoose = 2;                      //Saves the radio checked as a number to match 
                    }                                       //with the correct answer and check
                    else if (rdbAnswer3.Checked)            //if it is the correct answer
                    {                                       //
                        ansChoose = 3;                      //
                    }
                    else if (rdbAnswer4.Checked)
                    {
                        ansChoose = 4;
                    }

                    if (ansChoose == ansCorrect)
                    {
                        ++score;//Increment if answer is correct
                        MessageBox.Show("Correct!");//Displays that answer chosen was correct
                        lblCorrect.Text = score.ToString();
                        
                    }
                    else
                    {
                        ++wrongAns;//Increment if answer is incorrect
                        MessageBox.Show("Wrong!");//Displays that answer chosen was incorrect
                        lblWrong.Text = wrongAns.ToString();
                    }
                    if (!inputFile.EndOfStream)//Reads until end of file
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

                        rdbAnswer1.Checked = false;////////////////////////
                        rdbAnswer2.Checked = false;//uncheck radio buttons
                        rdbAnswer3.Checked = false;//when next question is displayed
                        rdbAnswer4.Checked = false;////////////////////////

                    }
                    else
                    {
                        if(score > wrongAns)//Checks if correct answers are more than wrong answers
                        {
                            MessageBox.Show("You have passed!!\nYou are a Genius");
                        }
                        else
                        {
                            MessageBox.Show("You have Failed!!\nGood luck next time");
                        }
                        inputFile.Close();//Closes file
                        btnNext.Text = "Finish"; //Changes the text of the next button to Finish
                        btnNext.Enabled = false;//Disables the next button
                    }
                }
            }
            catch (Exception ex)//Catches any exceptions
            {
                MessageBox.Show("Error-:" + ex.Message);//Displays error in message box
            }
            }

        }
    }

    

