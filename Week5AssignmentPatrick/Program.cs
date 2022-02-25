using System;

namespace ConsoleAppWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //activate class programs
            ProblemOne();
            ProblemTwo();
            ProblemFive();
        }

        //1) Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        static void ProblemOne()
        {
            //hold the amount of numbers divisble by 3 with no remainder
            int countIt = 0;

            //check each number between 1 and 100
            for (int i = 0; i < 100; i++)
            {
                //because the program will count 0 as "1", increase the value of i by 1 to make it more accurate
                //Console.WriteLine("[debug]:" + i + 1);
                if ((i + 1) % 3 == 0)
                {
                    countIt++;
                }
            }

            //output the amount of numbers divisible by 3 with no remainder
            Console.WriteLine("There are " + countIt + " numbers divisible by 3 with no remainder.");
        }

        //2) Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
        static void ProblemTwo()
        {
            //initialize variables
            int sum = 0;
            string isThisOK = "blah";
            bool stopThis = false;


            //explain the program's purpose to the user and request the user to input a number or type in "ok" to end the loop
            Console.WriteLine("\nPlease enter a number, or if you wish to stop, input: \"ok\"");


            //keep repeating until boolean is True
            while (stopThis == false)
            {
                //get User Input
                isThisOK = Console.ReadLine();

                //check input to either end the loop or add interger number to sum
                if (isThisOK == "ok" || isThisOK == "Ok" || isThisOK == "OK")
                {
                    //end boolean loop
                    stopThis = true;
                }
                else
                {
                    sum = sum + Convert.ToInt32(isThisOK);
                }
            }

            //once boolean loop has ended, output sum to user
            Console.WriteLine("The Sum is: " + sum);

        }

        //5) Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        static void ProblemFive()
        {
            //initialize variables
            string checkThis = " 5  , 3,        18     , 1, 14"; //[DEBUG] check if string splitting array is reciving the intergers
            int theBiggest = 0;

            Console.WriteLine("\nPlease enter a string of numbers divided by commas, remember to use spaces and commas appropiately");

            //recieve input for string from user
            checkThis = Console.ReadLine();

            //create a array that splits the string into intergers seperated by commas
            string[] splitThis = checkThis.Split(",");

            //go through the array and find the biggest
            foreach (string a in splitThis)
            {
                //Console.WriteLine("[DEBUG]: "+ a);

                if (Convert.ToInt32(a) > theBiggest)
                {
                    theBiggest = Convert.ToInt32(a);
                }
            }

            //output the biggest interger to the user
            Console.WriteLine("the biggest number is: " + theBiggest);




        }

    }
}
