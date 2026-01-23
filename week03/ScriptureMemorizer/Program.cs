using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Scripture> scriptureLibrary = new List<Scripture>();

        scriptureLibrary.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"));
        scriptureLibrary.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"));
        scriptureLibrary.Add(new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought doubt not fear not"));

       
        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture currentScripture = scriptureLibrary[index];

      
        string input = "";

        while (input != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText()); 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            
            input = Console.ReadLine();

            if (input != "quit")
            {
                currentScripture.HideRandomWords(3); 
            }
        }

        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Good job!");
    }
}