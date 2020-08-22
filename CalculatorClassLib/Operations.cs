using System;

namespace CalculatorClassLibrary
{
    //this class implements the IOperations interface for use in the GUI
    public class Operations : IOperations
    {
        string final = string.Empty;
        public double PerformOperation(string theOperator, double result, string screenresult)
        {
            switch (theOperator)
            {
                case "+":
                    final = (result + Double.Parse(screenresult)).ToString();
                    break;
                case "-":
                    final = (result - Double.Parse(screenresult)).ToString();
                    break;
                case "*":
                    final = (result * Double.Parse(screenresult)).ToString();
                    break;
                case "/":
                    if (screenresult == "0")
                    {
                        throw new DivideByZeroException();
                    }
                    final = (result / Double.Parse(screenresult)).ToString();
                    break;
                default:
                    break;
            }
            return result = Double.Parse(final);
        }
    }
}