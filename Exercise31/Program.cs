using System;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {

                Console.WriteLine("Please enter an index between 0-4");

                int index = Convert.ToInt32(Console.ReadLine());

                int[] nums = new int[5] { 2, 8, 0, 24, 51 };

                //Output
                Console.WriteLine($"The index: {index}");
                Console.WriteLine("_____________________ ");
                Console.WriteLine($"The value at index is: {FindIndex(index, nums)}");


                GetContinue();

            }
        }

        //Created a Method to find the index in above array.
        //Couldnt figure out how to add an exception in case they choose a number not in index
        public static int FindIndex(int index, int[] array)
        {
            int i = index;
            return array[i];
        }
        
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");

                return GetContinue();
            }
        }
    }
}
