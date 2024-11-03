namespace myLinqMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 6, 3, 4, 5 };

            int result = intArray.MyLast(item => item % 2 == 0);

            Console.WriteLine(result);

        }
    }
}
