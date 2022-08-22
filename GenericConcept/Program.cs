namespace GenericConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 1.2, 1.3, 1.4 };
            char[] charArray = { 'A', 'B', 'C' };


            Generic.toPrint(intArray);
            Generic.toPrint(doubleArray);
            Generic.toPrint(charArray);

            // Using Generic Method concept
            GenericMethod.toPrint<int>(intArray);
            GenericMethod.toPrint<double>(doubleArray);
            GenericMethod.toPrint<char>(charArray);

            // Using Generic Class concept

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }
    }
}