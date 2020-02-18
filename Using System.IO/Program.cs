using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//System.IO contains types that allow for reading and writing to files and data streams, 
//and types that provide basic file directory support
using System.IO;

namespace MidtermNS1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference from https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=netframework-4.8
            //and https://stackoverflow.com/questions/13262548/delete-a-file-being-used-by-another-process

            Console.WriteLine("Let's make a file.");
            //FUNCTION 1: Create a File using File.Create()
            //-----Part of the File Class, this method creates a file in the specified path and takes a string value argument
            while (true)
            {
                //Prompt user for file path, name, and type 
                Console.WriteLine("Specify a path including the file name and type you wish to create:");
                string path = Console.ReadLine();

                //Confirm file path for creation
                Console.WriteLine($"Are you sure you want to create {path}? (Y/N): ");
                string Answer = Console.ReadLine();
                Answer = Answer.ToLower();

                //If confirmed, create file
                if (Answer == "y")
                {
                    //Use the FileStream Class to get read/write access then create the file
                    //Use Create method to create the specified file at the specified location
                    FileStream createFile = File.Create(path);
                    Console.WriteLine($"{path} created");
                    
                    //Release the resources in order to do more work on the file
                    createFile.Dispose();
                    break;
                }
                //Else ask to skip
                else if (Answer == "n")
                {
                    Console.WriteLine("Skip this step? (Y/N): ");
                    Answer = Console.ReadLine();

                    //If user skips break loop
                    if (Answer.ToLower() == "y")
                        break;
                }
                //Return Invalid Input if user does not enter Y or N
                else
                    Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Lets add some text.");
            //FUNCTION 2 & 3: 
            //-File.Exists()
            //-----Determines if the specified file exists as True or False. Takes a string value argument. 
            //-File.WriteAllLines()
            //-----Can be used to create a new file and add text or add text to a file in a specified path.
            //-----Accepts a string value for the file path and a string array for the text to add.
            while (true)
            {
                //Prompt user for file path, name, and type to write to
                Console.WriteLine("Specify the file path you would like to write to: ");
                string path = Console.ReadLine();

                //Use the Exists method to verify that the file specified exists
                if (File.Exists(path) == true)
                {
                    //Prompt user for text to add
                    Console.WriteLine("Write the text you would like to add: ");

                    //Add the text to a string array
                    string[] textToAdd = new string[] { Console.ReadLine() };

                    //Use the WriteAllLines method to write the text to the file
                    File.WriteAllLines(path, textToAdd);
                    break;
                }

                //If the file path is invalid display message and ask to skip
                else
                {
                    Console.WriteLine("Invalid file path");
                    Console.WriteLine("Would you like to skip? (Y/N)");
                    string Answer = Console.ReadLine();


                    //If user skips break loop
                    if (Answer.ToLower() == "y")
                    {
                        break;
                    }
                }


            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Find out what text is in your file.");
            //FUNCTION 4: Read text from a file using File.OpenText()
            //-----Opens an existing UTF-8 encoded text file for reading. Accepts a string value as the file path.
            while (true)
            {
                //Prompt user for file path to open
                Console.WriteLine("Specify the file path to open: ");
                string path = Console.ReadLine();
                
                //Verify that the path exists
                if (File.Exists(path) == true)
                {
                    //If path is valid, read the text in the file
                    //Use the StreamReader Class to read characters from a byte stream
                    //Use OpenText method to open the file for reading
                    StreamReader readFile = File.OpenText(path);
                    
                    //Set the text in the file to a string variable
                    string fileText = readFile.ReadLine();
                    
                    //Display the text
                    Console.WriteLine(fileText);
                    
                    //Release resources in order to do more work on the file
                    readFile.Dispose();
                    break;
                }
                //If path does not exist return message and prompt user to skip 
                else
                {
                    Console.WriteLine("Invalid file path");
                    Console.WriteLine("Would you like to skip? (Y/N)");
                    string Answer = Console.ReadLine();
                    
                    //If user skips break loop
                    if (Answer.ToLower() == "y")
                    {
                        break;
                    }
                }

            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Let's delete a file.");
            //FUNCTION 5: Delete a file using File.Delete()
            //-----Deletes a specified file. Accepts a string value as the file path.
            while (true)
            {
                //Prompt user for file path
                Console.WriteLine("Please provide a file path for deletion: ");
                string path = Console.ReadLine();

                //Confirm file for deletion
                Console.WriteLine($"Are you sure you want to delete {path}? (Y/N): ");
                string Answer = Console.ReadLine();
                Answer = Answer.ToLower();

                //If confirmed, delete file
                if (Answer == "y")
                {
                    //Use delete method to delete file
                    File.Delete(path);
                    Console.WriteLine($"{path} deleted");
                    break;
                }
                //Else ask to skip
                else if (Answer == "n")
                {
                    Console.WriteLine("Skip this step? (Y/N): ");
                    Answer = Console.ReadLine();

                    //If user skips break loop
                    if (Answer.ToLower() == "y")
                    {
                        break;
                    }
                }
                //Return Invalid Input if user does not enter Y or N
                else
                    Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Goodbye");
            Console.ReadLine();

        }
    }
}
