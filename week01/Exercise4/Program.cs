using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        // Get numbers from user until they enter 0
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Calculate the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Find the smallest positive number
        int smallestPositive = int.MaxValue;  // Start with the largest possible integer
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were found.");
        }

        // Sort the list and display it
        numbers.Sort();
        Console.WriteLine("\nThe sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}