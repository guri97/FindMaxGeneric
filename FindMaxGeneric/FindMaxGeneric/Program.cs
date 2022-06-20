namespace Day13_FindMax
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum value finder");

            int integers = MaxNumberCheck.MaxIntegerNumber(4, 6, 2);
            Console.WriteLine(integers);
            double Double = MaxNumberCheck.MaxFloatNumber(1.2, 3.4, 5.6);
            Console.WriteLine(Double);
            string string1 = MaxNumberCheck.MaximumString("22", "23", "26");
            Console.WriteLine(string1);
            Console.WriteLine("Generic Method and Class");
            int max = GenericMaximum<int>.MaxValue(4, 6, 2);
            Console.WriteLine(max);
            double max1 = GenericMaximum<double>.MaxValue(1.2, 3.4, 5.6);
            Console.WriteLine(max1);
            string max2 = GenericMaximum<string>.MaxValue("22", "23", "26");
            Console.WriteLine(max2);
            Console.WriteLine("Generic Method and Class using sorting method");
            int[] arr = { 4, 6, 2 };
            GenericMaximumNumber<int> generic = new GenericMaximumNumber<int>(arr);
            generic.PrintMaxValue();
            double[] arr1 = { 1.2, 3.4, 5.6 };
            GenericMaximumNumber<double> generic1 = new GenericMaximumNumber<double>(arr1);
            generic1.PrintMaxValue();
            string[] arr2 = { "22", "23", "26" };
            GenericMaximumNumber<string> generic2 = new GenericMaximumNumber<string>(arr2);
            generic2.PrintMaxValue();




        }
    }
}