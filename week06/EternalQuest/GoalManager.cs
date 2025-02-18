using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuestProgram
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nEternal Quest Program");
                Console.WriteLine("1. Display Player Info");
                Console.WriteLine("2. List Goal Names");
                Console.WriteLine("3. List Goal Details");
                Console.WriteLine("4. Create Goal");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Save Goals");
                Console.WriteLine("7. Load Goals");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayPlayerInfo();
                        break;
                    case "2":
                        ListGoalNames();
                        break;
                    case "3":
                        ListGoalDetails();
                        break;
                    case "4":
                        CreateGoal();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        SaveGoals();
                        break;
                    case "7":
                        LoadGoals();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
        }

        public void ListGoalNames()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("Goal Details:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.Write("Enter goal type (Simple/Checklist/Eternal): ");
            string type = Console.ReadLine();
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            Goal goal = null;
            switch (type.ToLower())
            {
                case "simple":
                    goal = new SimpleGoal(name, description, points);
                    break;
                case "checklist":
                    Console.Write("Enter target: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
                case "eternal":
                    goal = new EternalGoal(name, description, points);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }

            _goals.Add(goal);
            Console.WriteLine("Goal created successfully.");
        }

        public void RecordEvent()
        {
            Console.WriteLine("Select a goal to record an event:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            int choice = int.Parse(Console.ReadLine()) - 1;

            if (choice >= 0 && choice < _goals.Count)
            {
                _goals[choice].RecordEvent();
                _score += _goals[choice].Points; // Fixed: Use the public property
                Console.WriteLine("Event recorded.");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        public void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        public void LoadGoals()
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string type = parts[0];
                    string[] details = parts[1].Split(',');

                    Goal goal = null;
                    switch (type)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]));
                            ((SimpleGoal)goal).RecordEvent(); // Mark as complete if needed
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[4]), int.Parse(details[5]));
                            ((ChecklistGoal)goal).RecordEvent(); // Update completion count
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
                            break;
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}