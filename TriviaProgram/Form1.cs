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
        int x = 0;
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

           /* try
            {
                inputFile = File.OpenText(@"questions.txt");
                MessageBox.Show("File exist\n");
                string line;
                int counter = 0;
                string[] lines = File.ReadAllLines(@"questions.txt");
                string firstLine = lines[0];

                while ((line = inputFile.ReadLine()) != null)
                {
                    switch(++counter)
                    {
                        case 1: lblQuestion.Text = line; break;
                        case 2: rdbAnswer1.Text = line; break;
                        case 3: rdbAnswer2.Text = line; break;
                        case 4: rdbAnswer3.Text = line; break;
                        case 5: rdbAnswer4.Text = line; break;
                        case 6: lblAnswer.Text = line; break;
                    }
                }
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("File does not exist\n" + ex.Message);
            }*/
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*string line;

            if (!inputFile.EndOfStream)
            {
                 line = inputFile.ReadLine();
                 
                lblQuestion.Text = line;
                
            }
            else
            {
                MessageBox.Show("End");
                inputFile.Close();
            }*/



            try
            {
                inputFile = File.OpenText(@"questions.txt");
                MessageBox.Show("File exist\n");
                string line;
                int counter = 0;
                string[] lines = File.ReadAllLines(@"questions.txt");
                string firstLine = lines[0];

                while ((line = inputFile.ReadLine()) != null)
                {

                    
                         
                        /*switch (++counter)
                    {Karim
                        case 1: lblQuestion.Text = line; break;
                        case 2: rdbAnswer1.Text = line; break;
                        case 3: rdbAnswer2.Text = line; break;
                        case 4: rdbAnswer3.Text = line; break;
                        case 5: rdbAnswer4.Text = line; break;
                        case 6: lblAnswer.Text = line; break;
                    }*/
                }
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("File does not exist\n" + ex.Message);
            }
        }
    }
}
    

