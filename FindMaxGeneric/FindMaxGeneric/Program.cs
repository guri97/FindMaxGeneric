namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder");
            // MaxNumberCheck maxNumberCheck = new MaxNumberCheck();
            int integers = MaxNumberCheck.MaxIntegerNumber(4, 6, 2);
            Console.WriteLine(integers);
            double Double = MaxNumberCheck.MaxFloatNumber(1.2, 3.4, 5.6);
            Console.WriteLine(Double);
            string string1 = MaxNumberCheck.MaximumString("22", "23", "26");
            Console.WriteLine(string1);


        }
    }
}