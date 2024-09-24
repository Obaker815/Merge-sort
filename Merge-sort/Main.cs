using Merge_sort;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // input a scentence from the user
            Console.WriteLine("input scentence to be merge sorted");
            string inputScentence = Console.ReadLine() + "";

            // remove whitespace
            inputScentence.Trim();

            // turns the input into a character array
            char[] scentenceArray = new char[inputScentence.Length];
            for (int i = 0; i < scentenceArray.Length; i++)
            {
                scentenceArray[i] = inputScentence[i];
            }

            // writes the array to the console
            Console.WriteLine(scentenceArray.MergeSort());
        }
    }
}