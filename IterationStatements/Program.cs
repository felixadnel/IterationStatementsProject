using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Read each comment and complete its instruction
            // like the example below

            // Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var num = 0;

            // Create a do-while loop and use the template below:
            // Increment num by 1
            // Then add num to the collection - numbers
            // Hint: reference num inside of the Add method's parentheses
            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100); // <---- While your variable is less than 100

            // Create a while loop
            // <--- While num is less than 200
            while (num < 200)
            {
                // Increment num by 1
                // Then add num to the collection numbers
                //HINT: copy how this was done in the do-while loop
                num++;
                numbers.Add(num);
            }

            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");

            // Create a foreach loop using the collection - numbers
            // In the scope of the foreach loop, print each number in numbers
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // In your initializer, set the value of i to the last index of the numbers list (numbers.Count - 1)
            // In your conditional, as long as i is greater than or equal to 0
            // Decrement i by 1 in each iteration
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                // Place numbers[i] inside the Console.WriteLine() method
                Console.WriteLine(numbers[i]);
            }

            //------------End of exercise------------
        }
    }
}
