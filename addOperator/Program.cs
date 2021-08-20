using System;

namespace addOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string captureUserInput;
            var x = 0;
            var y = 0;

            do
            {   //for the input. its using the readuserinput method for both of the variable x and y.

                // Capture first number. 
                x = readUserInput("Please enter the first number: ");

                // Capture 2nd Number
                y = readUserInput("Please enter the second number: ");





                //  sum results. its uses the add function and printing out the result.
                var output = add(x, y);

                Console.WriteLine($"Total Sum :{output}");


                Console.WriteLine("are you want to exit");



                // Capture whether to exit or continue
                captureUserInput = Console.ReadLine();

                /*this part of the do while loop will read the user input from captureUserInput and
                if the user has enter "y" then it will terminate the whole console operation*/
            } while (captureUserInput.ToLower() != "y");

        }

        public static int readUserInput(string message)
        {
            var complete = false;
            int x;

            /*this do while loop will continue endlessly until the user has enter a number while the boolean
            statement complete is false. */
            do
            {
                //its printing out the enter a number message by using the readUserInput parameter.
                Console.WriteLine(message);

                //the var input is reading the user input whether it is a string or int.
                var Input = Console.ReadLine();

                // it is trying convert a string to an int. it is pass on the input value to the output int x
                var Number = int.TryParse(Input, out x);

                /*if the user has enter a number then it will change the boolean value and it will 
                terminate the do while loop. */
                if (Number == true)
                {
                    complete = true;
                }

            } while (complete == false);

            return x;
        }

        public static int add(int a, int b)
        {
            return a + b;

        }
    }
}

