using System;
using System.Collections.Generic;

namespace Input_Reversal
{
    public class InputReverse
    {
        /// <summary>
        /// This method is used to return the messge when there is no input or the input
        /// contains only spaces.
        /// </summary>
        public static string blankInputMessage()
        {
            return ("Input should contain some content!");
        }

        /// <summary>
        /// This function performs the reversal implementation using Stack method as it works on the 
        /// LIFO(Last In First Out) principle.
        /// </summary>
        /// <param name="input">The input string provided by the user for reversing.</param>
        /// <returns>Returns the reversed output.</returns>
        public static string inputReverse(string input)
        {
            if ((String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)))
            {
                return blankInputMessage();
            }
            else
            {
                Stack<string> inputStack = new Stack<string>();
                string reverseString = String.Empty;
                for (int counter = 0; counter < input.Length; counter++)
                {
                    inputStack.Push(input[counter].ToString());
                }
                for (int stackCounter = 0; stackCounter < input.Length; stackCounter++)
                {
                    reverseString += inputStack.Pop();
                }
                return ("The reverse string is : " + reverseString);
            }
        }

        /// <summary>
        /// Input given by the user is reversed and the reversed output is displayed.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Please provide your input");
            string input = Console.ReadLine();
            string output=inputReverse(input);
            Console.WriteLine(output);
        }

    }
}
