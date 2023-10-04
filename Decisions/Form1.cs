using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ageButton_Click(object sender, EventArgs e)
        {
            /// Create a variable to hold a person's age. Then use 
            /// that variable to determine if the person is old 
            /// enough to vote. Display an appropriate message based
            /// on whether they can or can't vote  

            int age;
            age = Convert.ToInt32(ageInput.Text);

            if (age < 18)
            {
                voteOutput.Text = "you can't vote";

            }
            else
            {
                voteOutput.Text = "you can vote";
            }

        }

        private void workButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines how many overtime 
            /// hours an employee has worked. Any hours over 40 is 
            /// considered overtime. Make sure that your output matches
            /// the sample output below exactly.
            ///
            /// Sample Output for 15 hours:
            /// You worked 15 hours
            /// 
            /// Sample output for 45 hours:
            /// You worked 40 hours plus 5 hours overtime

            int hours, overtime;

            hours =  Convert.ToInt32(hoursInput.Text);

            if (hours > 40)
            {
                overtime = hours - 40;
                workOutput.Text = $"you worked 40 hourse plus {overtime} hour(s) overtime";

            }

            else
            {
                workOutput.Text = $"you worked {hours} hours";

            }


        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines the max value 
            /// between 2 values inputted by the user. The output 
            /// should match the following:
            /// 
            /// Sample output for inputs 34, 12
            /// The max value is: 34
            /// 
            /// Sample output for inputs 22, 77
            /// The max value is: 77

            int num1, num2;
            num1 = Convert.ToInt32(num1Input.Text);
            num2 = Convert.ToInt32(num2Input.Text);

            if (num1 > num2)
            {
                maxOutput.Text = $"The max value is {num1}";
            }

            else
            {
                maxOutput.Text = $"The max value is {num2}";

            }


        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines if an entered year
            /// is a leap year. The output should match the following:
            /// 
            /// Sample output for inputs 2002
            /// 2002 is not a leap year
            /// 
            /// Sample output for inputs 2016
            /// 2016 is a leap year
           int year = Convert.ToInt32(yearInput.Text);

            if (year % 4 == 0)
            {
                yearOutput.Text = $"{year} is a leap year";
            }

            else
            {
                yearOutput.Text = $"{year} is not a leap year";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yearInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //takes an integer as input
            // if statements to test if it is positive or negative 
            //check to see if the entered value is divisible by 7
           

            int integer = Convert.ToInt32(integerinput.Text);

            if (integer >= 0)
            {
                integeroutput.Text = $"{integer} is a positive number";

            }

            else
            {
                integeroutput.Text = $"{integer} is a negative number";
            }

            if (integer % 7 == 0)
            {
                integeroutput.Text += $"{integer} is divisable by 7";
            }
            else
            {
                integeroutput.Text += $"{integer} is not divisable by 7";
            }
        }

        private void integerlable_Click(object sender, EventArgs e)
        {

        }
    }
}
