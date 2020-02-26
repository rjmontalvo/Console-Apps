//Namespace #3: System
/* The System namespace contains fundamental classes and base classes that define commonly-used value 
 * and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.
 * https://docs.microsoft.com/en-us/dotnet/api/system?view=netframework-4.8
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermNS3
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCTION #1: System.String.IndexOf()
            //https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof?view=netframework-4.8#System_String_IndexOf_System_String_
            while (true)
            {
                //Display title for this section
                Console.WriteLine("===Example 1: Using IndexOf()===");
                
                //Prompt the user for text and assign to str1
                Console.WriteLine("Enter some text:");
                string str1 = Console.ReadLine();

                //Prompt the user for a string to search for
                Console.WriteLine("Enter a word to search for in the string: ");
                string searchWord = Console.ReadLine();

                /*****IndexOf()****** 
                 * Used to report the 0 based index (as an int) of the first occurance of the specified string
                 * in the instance syntax: <string to search>.IndexOf(string to search for);
                 */
                //get the index of the word and assign it to strInd
                int strInd = str1.IndexOf(searchWord);
                //if the string is found the index will be >= 0 so we will display a message
                if (strInd >= 0)
                {
                    Console.WriteLine($"{searchWord} begins at index {strInd}.");
                }
                //else we will say that it was not found
                else
                {
                    Console.WriteLine($"{searchWord} not found in string");
                }

                //prompt the user to exit or go again
                Console.WriteLine("Exit? (Y/N): ");
                string exitInp = Console.ReadLine();
                if (exitInp.ToLower() == "y")
                {
                    break;
                }
            }

            //FUNCTION #2: System.String.Contains()
            //https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?view=netframework-4.8#System_String_Contains_System_String_
            while (true)
            {
                //Prompt the user for some text and assign it to str1
                Console.WriteLine("===Example 2: Using Contains()===");
                Console.WriteLine("Enter some text:");
                string str1 = Console.ReadLine();

                //Prompt the user for a string to search for and assign it to searchWord
                Console.WriteLine("Enter a word to search for in the string: ");
                string searchWord = Console.ReadLine();

                /*****Contains()****** 
                 * Returns a boolean value indicating whether a specified substring occurs within this string.
                 * Syntax: <string to search>.Contains(string to search for);
                 */

                //if the string contains the string we are looking for return the first message
                if (str1.Contains(searchWord))
                {
                    Console.WriteLine($"'{searchWord}' is in the string '{str1}'.");
                }
                //else return the second message
                else
                    Console.WriteLine($"'{searchWord}' is not in the string '{str1}'.");

                //prompt the user to go again
                Console.WriteLine("Exit? (Y/N): ");
                string exitInp = Console.ReadLine();
                if (exitInp.ToLower() == "y")
                {
                    break;
                }
            }

            //FUNCTION #3: System.String.Insert()
            //https://docs.microsoft.com/en-us/dotnet/api/system.string.insert?view=netframework-4.8#System_String_Insert_System_Int32_System_String_
            while (true)
            {
                //Create blank strings to use
                string animal1 = "";
                string animal2 = "";

                /*Prompt the user for input and call checkNullOutLowerTrim() to get the output
                 * Assign the output to animal1
                */
                Console.WriteLine("===Example 3: Using String.Insert()===");
                string animalPrompt1 = "Enter the name of an animal: ";
                animal1 = checkNullOutLowerTrim(animal1, animalPrompt1);

                /*Prompt the user for input and call checkNullOutLowerTrim() to get the output
                 * Assign the output to animal2
                 */
                string animalPrompt2 = "Enter the name of another animal: ";
                animal2 = checkNullOutLowerTrim(animal2, animalPrompt2);

                //Put the animals into a sentence we can manipulate later and print the sentence to the screen.
                string strTarget = $"The {animal1} chased the {animal2}.";
                Console.WriteLine("The original string is:\n'{0}'",strTarget);
                
                //Create an empty string
                string adj1 = "";

                /*Prompt the user for input and call checkNullOutLowerTrim() to get the output
                 * Assign the output to adj1
                 */
                string adj1Prompt = $"\nEnter an adjective (or group of adjectives) to describe the {animal1}: ==> ";
                adj1 = checkNullOutLowerTrim(adj1, adj1Prompt);

                /*Prompt the user for input and call checkNullOutLowerTrim() to get the output
                 * Assign the output to adj1
                 */
                string adj2 = "";
                string adj2Prompt = $"\nEnter an adjective (or group of adjectives) to describe the {animal2}: ==> ";
                adj2 = checkNullOutLowerTrim(adj2, adj2Prompt);
                
                //Since the words are going into a sentence add a space after the words
                adj1 += " ";
                adj2 += " ";

                //*****Insert()*****
                /*Returns a new string in which a specified string is inserted at a specified index position in this instance.
                 * Accepts an Int32 parameter to index where to put the new string 
                 * Accepts a string parameter to insert into the specified position
                 * Syntax: <string to insert to>.Insert(<int index for string>, <string to add>);
                 */
                //Insert the adjectives before the animal types in the string
                strTarget = strTarget.Insert(strTarget.IndexOf(animal1), adj1);
                strTarget = strTarget.Insert(strTarget.IndexOf(animal2), adj2);

                //Print the final string
                Console.WriteLine("\nThe final string is:\n'{0}'",strTarget);

                //Ask the user to go again
                Console.WriteLine("Exit? (Y/N): ");
                string exitInp = Console.ReadLine();
                if (exitInp.ToLower() == "y")
                {
                    break;
                }
            }
 
        }

        /// <summary>
        /// Prompts the user with the message until input is given
        /// </summary>
        /// <param name="wordToCheck">String to check if empty or null</param>
        /// <param name="message">Message to prompt the user for input</param>
        /// <returns>Returns the users input as a lowercase string with no trailing or leading white space</returns>
        //FUNCTION #4: System.String.IsNullOrEmpty()
        //https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=netframework-4.8#System_String_IsNullOrEmpty_System_String_
        //FUNCTION #5: System.String.Trim()
        //https://docs.microsoft.com/en-us/dotnet/api/system.string.trim?view=netframework-4.8#System_String_Trim
        //FUNCTION #6: System.String.ToLower()
        //https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower?view=netframework-4.8#System_String_ToLower
        static string checkNullOutLowerTrim(string wordToCheck, string message)
        {
            //*****IsNullOrEmpty()*****
            /* Indicates whether the specified string is null or an empty string ("") by returning a bool.
             * Accepts a string parameter
             * Syntax: String.IsNullOrEmpty(<string to check>)
             */
            //Continue to prompt the user for input while their input is empty or null
            while (String.IsNullOrEmpty(wordToCheck) == true)
            {
                Console.Write(message);
                //Since the input will go in the middle of a sentence we need to convert it to lower
                //We also want to remove any whitespace from the end or beginning
                //*****ToLower()*****
                /* Returns a copy of this string converted to lowercase.
                 * Syntax: <string to convert>.ToLower()
                 */
                //*****Trim*****
                /* Removes all leading and trailing white-space characters from the current string.
                 * Syntax: <string to edit>.Trim()
                 */
                wordToCheck = Console.ReadLine().ToLower().Trim();
            }
            //return the non-empty/null input after it is converted to lowercase and whitespace has been removed
            return wordToCheck;
        }
    }
}
