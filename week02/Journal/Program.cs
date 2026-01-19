using System;

// EXCEEDING REQUIREMENTS:
// I added a "Mood" tracking feature. 
// The user is prompted to enter how they felt today after writing their entry.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string input = Console.ReadLine();
            
            // This prevents the app from crashing if you type letters instead of numbers
            if (!int.TryParse(input, out choice))
            {
                choice = -1;
            }

            // --- OPTION 1: WRITE ---
            if (choice == 1) 
            {
                Entry newEntry = new Entry();
                
                DateTime currentTime = DateTime.Now;
                newEntry._date = currentTime.ToShortDateString();

                newEntry._promptText = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n{newEntry._promptText}");
                
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                Console.Write("How are you feeling today? (Mood): ");
                newEntry._mood = Console.ReadLine();

                theJournal.AddEntry(newEntry);
                Console.WriteLine("Entry Added!"); // Feedback so you know it worked
            }
            // --- OPTION 2: DISPLAY ---
            else if (choice == 2) 
            {
                Console.WriteLine("\n--- Journal Entries ---");
                theJournal.DisplayAll();
                Console.WriteLine("-----------------------");
            }
            // --- OPTION 3: LOAD ---
            else if (choice == 3) 
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            // --- OPTION 4: SAVE ---
            else if (choice == 4) 
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            // --- OPTION 5: QUIT ---
            else if (choice == 5) 
            {
                Console.WriteLine("Goodbye!");
            }
            // --- INVALID ---
            else
            {
                Console.WriteLine("Invalid choice. Please type 1-5.");
            }
        }
    }
}