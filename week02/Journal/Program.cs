using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                writeNewEntry(journal, promptGenerator);
                break;
                case "2":
                journal.DisplayAll();
                break;

                case "3":
                SaveJournal(journal);
                break;
                 case "4":
                LoadFromFile(journal);
                break;

                case "5":
                Console.WriteLine("Exiting program...");
                return;

                default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;


            }
            
        }


    }
    static void writeNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write($"Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyy-mm-dd");

        Entry newEntry = new Entry(date,prompt,response);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully");
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter file to save to journal:");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);

    }
    static void LoadFromFile(Journal journal)
    {
        Console.WriteLine("Enter filename to load journal:");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

}