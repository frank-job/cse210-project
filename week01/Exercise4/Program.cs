using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter  a number but zero(0) is for quiting ");

       int UserNumber = -1;

       while (UserNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            UserNumber = int.Parse(userResponse);
        

            if (UserNumber != 0)
            {
            numbers.Add(UserNumber);
            }
        }
            // int sum = 0;
            // foreach (int number in numbers)
            // {
            // sum += number;
            if (numbers.Count > 0)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                sum += number;
                }
        
            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average i {average}");
        
        /// <summary>
        /// Initializes the maximum value to the first element of the numbers array.
        /// </summary>
        /// 
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                
            }
                 Console.WriteLine($"The max is: {max}");

            }
        
        
        }

        
    
}
        
    

