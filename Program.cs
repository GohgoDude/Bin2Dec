using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lengthCondition = false;
            bool numberCondition = false;
            int decimalOutput = 0;
            int charToInt;
            string binaryInput = "0";
            char zero = '0';
            char one = '1';

            // Initiate while loop to satisfy both conditions
            //  - input can only be 1 to 8 digits long
            //  - input can only be 0 or 1
            while (!lengthCondition || !numberCondition)
            {
                // Request and store user input
                binaryInput = Console.ReadLine();

                // Make sure user can only input 1 to 8 digits (INCLUSIVE)
                if ((binaryInput.Length <= 8) && (binaryInput.Length >= 1))
                {
                    lengthCondition = true;
                }

                // Check each character in the string
                foreach (var character in binaryInput)
                {
                    // Make sure user can only input 0 or 1
                    if ((character == zero || character == one))
                    {
                        numberCondition = true;
                    }
                    else
                    {
                        numberCondition = false;
                        break;
                    }
                }
            }

            // Convert user input (enter function below)
            for (int i = 0; i < binaryInput.Length; i++)
            {
                charToInt = int.Parse(binaryInput[i].ToString());
                decimalOutput = (int)(decimalOutput + charToInt * Math.Pow(2, i));
            }

            // Output user input to console
            Console.WriteLine(binaryInput + " is equal to " + decimalOutput);

        }
    }
}
