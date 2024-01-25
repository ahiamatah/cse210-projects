using System;

class Program
{
    static void Main(string[] args)
    {
        

        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        string date = currentDate.ToString();
        int userResponse;
        do
        {
            Console.WriteLine("Welcome to the Journal Program!");

            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do?");
            string response = Console.ReadLine();
            userResponse = int.Parse(response);

            

            if (userResponse == 1)
            {
                // Random number
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(0, 10);

                // Questions
                List<String> _questions = new List<String>();
                _questions.Add("Who was the most interesting person I interacted with today?");
                _questions.Add("What was the best part of my day?");
                _questions.Add("How did I see the hand of the Lord in my life today?");
                _questions.Add("What was the strongest emotion I felt today?");
                _questions.Add("If I had one thing I could do over today, what would it be?");
                _questions.Add("Which scripture did you study from today?");
                _questions.Add("How many hours did you spend on Sripture study today?");
                _questions.Add("How were you knid today?");
                _questions.Add("How have you helped someone in need today?");
                _questions.Add("What blessings did you ask for today? ");

                // Getting random queston
                string randomQuestion = _questions[randomNumber];
                Console.WriteLine(randomQuestion);
                Console.Write(">");
                string userAnswer = Console.ReadLine();

                // Storing Date, Propmt, Random Question an7 userAnswer in a new variable journalEntry
                string journalentry = $"Date: {currentDate} - Prompt: {randomQuestion}\n{userAnswer}";
                //Writing Entry to Journal
                StreamWriter journalWriter = new StreamWriter("TextFiles//journal.txt");
                List<string> entries = new List<string>();
                entries.Add(journalentry);

                foreach (string entry in entries)
                {
                    journalWriter.WriteLine(entry);
                }

                journalWriter.Close();
            }
            else if (userResponse == 2)
            {
                Console.WriteLine();
                
                const string journalPath = "TextFiles\\journal.txt";
                StreamReader fileReader = new StreamReader(journalPath);

                string? line = fileReader.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line  = fileReader.ReadLine(); 
                }
                fileReader.Close();
            }
        }while (userResponse != 5);
    }
    
}