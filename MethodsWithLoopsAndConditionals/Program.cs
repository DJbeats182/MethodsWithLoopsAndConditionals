namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.PrintRange(34, 5);
            Console.WriteLine("Welcome to my Methods with Loops and Conditionals Program!!\n");
            Methods.delay(2000);
            Console.WriteLine("Press any \"Enter\" to continue");
            Console.ReadLine();


            //------------User-Input-Range-----------------------------
            Console.WriteLine("Lets start by making a list of numbers in decsending order.\n");
            Console.WriteLine("Enter the largest number in your range:\n");
            int ceiling = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the smallest number in your range:\n");
            int floor = int.Parse(Console.ReadLine());
            Methods.PrintRange(ceiling, floor);
            Console.WriteLine("There is your list :)\n");
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();

            //------------Range-By-Three----------------------------------
            Console.WriteLine("Next let's make a list of numbers in ascending order and increment by 3.\n");
            Console.WriteLine("Enter the smallest number in your range:\n");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the largest number in your range:\n");
            int b = int.Parse(Console.ReadLine());
            Methods.RangeByThree(a, b);
            Console.WriteLine("There is your list :)\n");
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();

            //------------Equality-Test----------------------------------
            Console.WriteLine("Now we will test to the equality of two numbers.\n");
            Console.WriteLine("Let's see if the numbers are equal to each other.\n");
            Console.WriteLine("Give me a number\n");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number\n");
            int secondNum = int.Parse(Console.ReadLine());
            Methods.EqualTo(firstNum, secondNum);
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();

            //------------Even-Or-Odd--------------------------------------
            Console.WriteLine("Okay time to see whether your number is even or odd.\n");
            Console.WriteLine("Enter your number:");
            int testNum = int.Parse(Console.ReadLine());
            Methods.EvenOrOdd(testNum);
            Console.WriteLine("Press \"Enter\" to continue\n");
            Console.ReadLine();

            //------------Positive-Or-Negative--------------------------------
            Console.WriteLine("Similarily let's see if a number is positve or negative.\n");
            //Console.WriteLine("Now let's see whether a number is positive or negative.");
            Console.WriteLine("What is the number you would like to test?:\n");
            int checkNumSign = int.Parse(Console.ReadLine());
            Methods.PosOrNeg(checkNumSign);
            Console.WriteLine("Press \"Enter\" to continue\n");
            Console.ReadLine();

            //------------Voting-Age-Test---------------------------------------------------
            Console.WriteLine("Are you old enough to Vote?\n");           
            Methods.VotingAge();
            Console.WriteLine("Press \"Enter\" to continue\n");
            Console.ReadLine();

            //-----------Range-Check------------------------------------------------------------
            Console.WriteLine("Is your number within the range: -10 to 10?:\n");
            int check = int.Parse(Console.ReadLine());
            Methods.RangeCheck(check);
            Console.WriteLine("Press \"Enter\" to continue\n");
            Console.ReadLine();

            //---------------Multiplication-Table-----------------------------------------------
            Console.WriteLine("Input a number between 1 and 12 to recieve its multiplication table:\n");
            int multTab = int.Parse(Console.ReadLine());
            Methods.MultTable(multTab);
            Console.WriteLine("You are finished with the program!");
            Console.WriteLine("Press \"Enter\" to Exit");
            Console.ReadLine();

        }
    }
}