using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Write your grade? ");
         string gradeInput = Console.ReadLine();
            int grade = int.Parse(gradeInput);
        
        if (grade >= 95)
        {
            Console.WriteLine("Your grade is A+");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Your grade is A");
        }

        else if (grade >= 85)
        {
            Console.WriteLine("Your grade is B+");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is B");
        }

        else if (grade >= 75)
        {
            Console.WriteLine("your grade is C+");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }

        else if (grade >= 65)
        {
            Console.WriteLine("your grade is D+");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else 
        {
            Console.WriteLine("your grade is F");
        }
    }
}


