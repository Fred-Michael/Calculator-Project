namespace CalculatorClassLibrary
{
    //Interface for the Operations in the app
    public interface IOperations
    {
        /// <summary>
        /// Takes in three parameters and performs the required operation based on the value of the operator
        /// </summary>
        /// <param name="Operator"></param>
        /// <param name="result"></param>
        /// <param name="screenResult"></param>
        /// <returns>returns a double on the operation performed</returns>
        double PerformOperation(string Operator, double result, string screenResult);
    }
}