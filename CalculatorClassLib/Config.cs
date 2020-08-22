namespace CalculatorClassLibrary
{
    public static class Config
    {
        //Config file that ensures the linking between the frontend and backend of the calculator app
        public static IOperations Linker { get; private set; }
        public static void Initialize()
        {
            Operations operation = new Operations();
            Linker = operation;
        }
        public static void Uninitiate()
        {
            Linker = null;
        }
    }
}