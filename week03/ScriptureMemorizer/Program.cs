using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
        };

        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
        
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;

            } 
            scripture.HideRandomWords(2);
            if (scripture.IsCompletelyHidden())
            {
                
                Console.WriteLine(scripture.GetDisplayText());
                break;

            }
    
        }
    }

}