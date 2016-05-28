using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TCdatabase
{
    class Program
    {

        // Variables.
        
        static void Main(string[] args)
        {

            /// <summary>
            /// variable that will be a string composition of entire file
            /// </summary>
            string[] fileText = null;

            /// <summary>
            /// String for file path.
            /// </summary>
            string filePath = @"C:\Users\thomashinson\Documents\TCdata\";

            /// <summary>
            /// filename
            /// </summary>
            string fileName = string.Empty;

            /// <summary>
            /// Read the filename from console.
            /// </summary>
            Console.Write("Please input storm list file name (.txt): ");
            fileName = Console.ReadLine();

            /// <summary>
            /// Attempt to open file, if not, add error messages.
            /// </summary>
            string errorMessages = string.Empty;

            /// Try block to read file.
            try
            {
                if( File.Exists(filePath + fileName)) {
                    fileText = System.IO.File.ReadAllLines(@"C:\Users\thomashinson\Documents\TCdata\" + fileName);
                } else
                {
                    errorMessages += (Environment.NewLine + "File does not exist as specified." + Environment.NewLine);
                }
                
            } catch (Exception ex)
            {
                errorMessages += (Environment.NewLine + ex.Message + Environment.NewLine);
            }


            /// <summary>
            /// Create a TC_Database object.
            /// </summary>
            


            /// <summary>
            /// Determine if errorMessages is empty and if successful
            /// </summary>
            if( errorMessages == "" )
            {
                Console.WriteLine("Program execution was successful.");
            } else
            {
                Console.WriteLine(errorMessages);
            }

            Console.ReadKey();
        }
    }
}
