using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodsWithLoopsAndConditionals;

internal class Methods
{
    public static void PrintRange(int ceiling, int floor)
    {
        for (int i = ceiling; i >= floor; i--)
        {
            if (ceiling < floor)
            {
                Console.WriteLine("Make sure you entered the larger number first");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void RangeByThree(int a, int b)
    {
        for (int i = a; i <= b; i += 3)
        {
            Console.WriteLine(i);
        }
    }

    public static void EqualTo(int num1, int num2)
    {

        if (num1 == num2)
        {
            Console.WriteLine($"{num1} is equal to {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} is NOT equal to {num2}");
        }

    }

    public static void EvenOrOdd(int response)
    {
        if (response % 2 == 0)
        {
            Console.WriteLine($"{response} is an EVEN number");
        }
        else
        {
            Console.WriteLine($"{response} is an ODD number");
        }
    }

    public static void PosOrNeg(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"{num} is a positive number");
        }
        else if (num == 0)
        {
            Console.WriteLine($"{num} is neither positive or negative");
        }
        else
        {
            Console.WriteLine($"{num} is a negative number");
        }
    }

    public static void VotingAge()
    {        
        bool candidateAge;
        do
        {
            Console.WriteLine("Enter in your age:\n");
            candidateAge = int.TryParse(Console.ReadLine(), out int input);
            if (candidateAge)
            {
                if (input >= 18)
                {
                    Console.WriteLine("Awesome, it looks like you are old enough to Vote!!!");
                }
                else
                {
                    int yearsToWait = 18 - input;
                    Console.WriteLine($"Sorry you are not old enough to vote, wait {yearsToWait}" +
                        $" more years and then youll be old enough to vote.");
                }
            }
            else
            {
                Console.WriteLine("Sorry incorrect input. Please try again!");                
            }
        } while (!candidateAge);
        
        
    }

    public static void RangeCheck(int numCheck)
    {
        if (numCheck >= -10 && numCheck <= 10)
        {
            Console.WriteLine($"it looks like {numCheck} does fit with the range -10 to 10!");
        }
        else
        {
            Console.WriteLine($"Sorry! {numCheck} falls outside of the range -10 to 10.");
        }
    }

    public static void MultTable(int multiply)
    {
        for (int i = 1; i <= 12; i++)
        {
            int answer = i * multiply;
            Console.WriteLine($"{i} X {multiply} = {answer}");
        }
    }

    public static void delay(int Time_delay) // I did not right this method haha, I'm just using it to make my program run a little smoother
    {
        int i = 0;
        var ameTir = new System.Timers.Timer();
        var delayTimer = new System.Timers.Timer();
        delayTimer.Interval = Time_delay;
        delayTimer.AutoReset = false; //so that it only calls the method once
        delayTimer.Elapsed += (s, args) => i = 1;
        delayTimer.Start();
        while (i == 0) { };
    }
}
