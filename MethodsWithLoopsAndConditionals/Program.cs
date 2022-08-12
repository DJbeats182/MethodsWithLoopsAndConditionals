namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my Methods with Loops and Conditionals Program!!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();


            //------------User-Input-Range-----------------------------
            Console.WriteLine("Lets start by making a list of numbers in decsending order.");
            Console.WriteLine("Enter the largest number in your range:");
            int ceiling = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the smallest number in your range:");
            int floor = int.Parse(Console.ReadLine());
            Methods.PrintRange(ceiling, floor);
            Console.WriteLine("There is your list :)");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //------------Range-By-Three----------------------------------
            Console.WriteLine("Next let's make a list of numbers in ascending order and increment by 3.");
            Console.WriteLine("Enter the smallest number in your range:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the largest number in your range:");
            int b = int.Parse(Console.ReadLine());
            Methods.RangeByThree(a, b);
            Console.WriteLine("There is your list :)");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //------------Equality-Test----------------------------------
            Console.WriteLine("Now we will test to the equality of two numbers.");
            Console.WriteLine("Let's see if the numbers are equal to each other.");
            Console.WriteLine("Give me a number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number");
            int secondNum = int.Parse(Console.ReadLine());
            Methods.EqualTo(firstNum, secondNum);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //------------Even-Or-Odd--------------------------------------
            Console.WriteLine("Okay time to see whether your number is even or odd.");
            Console.WriteLine("Enter your number:");
            int testNum = int.Parse(Console.ReadLine());
            Methods.EvenOrOdd(testNum);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //------------Positive-Or-Negative--------------------------------
            Console.WriteLine("Similarily let's see if a number is positve or negative.");
            //Console.WriteLine("Now let's see whether a number is positive or negative.");
            Console.WriteLine("What is the number you would like to test?:");
            int checkNumSign = int.Parse(Console.ReadLine());
            Methods.PosOrNeg(checkNumSign);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //------------Voting-Age-Test---------------------------------------------------
            Console.WriteLine("Are you old enough to Vote?");
            Console.WriteLine("Enter in your age:");
            int candidateAge = int.Parse(Console.ReadLine());
            Methods.VotingAge(candidateAge);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //-----------Range-Check------------------------------------------------------------
            Console.WriteLine("Is your number within the range: -10 to 10?:");
            int check = int.Parse(Console.ReadLine());
            Methods.RangeCheck(check);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            //---------------Multiplication-Table-----------------------------------------------
            Console.WriteLine("Input a number between 1 and 12 to recieve its multiplication table:");
            int multTab = int.Parse(Console.ReadLine());
            Methods.MultTable(multTab);
            Console.WriteLine("You are finished with the program!");
            Console.ReadLine();

        }
    }
}