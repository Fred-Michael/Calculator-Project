using System;
using System.Windows.Forms;
using CalculatorClassLibrary;

namespace CalculatorUI
{
    public partial class Result : Form
    {
        //outcome variable that holds the final answer
        double outcome = 0;
        //operator variable that holds the sign of the operator pressed
        string Operator = "";
        //bool operator that checks if an operation is performed
        bool isOperationPerfomed = false;
        //a variable of type 'NextMove' used to implement 'NextAction' class
        public NextMove Action;
        //bool operator that checks if the '=' button is pressed
        bool pressedEquals = false;

        private readonly IOperations Calculate;

        public Result(IOperations calculate)
        {
            InitializeComponent();
            this.Calculate = calculate;
        }

        //this method handles all number buttons pressed, including '.' and '+/-'
        private void buttonClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            //the below instantiates a class called NextMove and passes it to 'Action' of the same class type
            //the class handles negation and checking for '.' in the display of the calculator.
            Action = new NextMove(resultScreen, btn);
            if ((resultScreen.Text == "0") || (isOperationPerfomed))
            {
                resultScreen.Clear();
                isOperationPerfomed = false;
            }

            Action.ContainsDotOrNot();
            isOperationPerfomed = false;
        }

        //this method handles the clearing of the screen
        private void clear_Field(object sender, EventArgs e)
        {
            resultScreen.Text = "0";
            outcome = 0;
        }

        //this method negates the number if positive and vice versa
        private void NegateOrNot(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Action = new NextMove(resultScreen, btn);
            resultScreen.Text = Action.NegateOrNot();
        }

        //this method handles the operator button click
        private void operator_event(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            //here, a check is done to see if the '=' button is not pressed, another operator is chosen and the outcome(i.e result) has a number.
            //if the above two conditions are met, the first block below runs. this makes a call to the performOperation
            //method in the backend to perform interim operations on the operands; meaning that the '=' button
            //can give a result of the operations, or the chaining of multiple operators can give a result
            if (outcome != 0 && !pressedEquals)
            {
                Operator = btn.Text;
                resultScreen.Text = Calculate.PerformOperation(Operator, outcome, resultScreen.Text).ToString();
                outcome = Double.Parse(resultScreen.Text);
                isOperationPerfomed = true;
            }
            //if the above conditions are not met, the first number on the screen is assigned to 'outcome', and the operator is taken note of
            else
            {
                Operator = btn.Text;
                outcome = Double.Parse(resultScreen.Text);
                isOperationPerfomed = true;
                pressedEquals = false;
            }
        }

        //here, the implementation of the '=' button is done. Once this button is fired,
        //it makes a call to the Operations class in the backend to perform the necessary
        //operations without having to perform the operations here.
        private void get_Result(object sender, EventArgs e)
        {
            try
            {
                pressedEquals = true;
                resultScreen.Text = Calculate.PerformOperation(Operator, outcome, resultScreen.Text).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        #region implementation eror. Kindly ignore
        private void _(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}