using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[5] { "The Mitochondria is the powerhouse of the cell.", "Sleep is great.", "Warcraft 3 Reforged was amazing!", "Warcraft 3 was amazing!", "BFA was the best expansion ever!" };
            bool[] answers = new bool[5] { true, true, false, true, false };
            bool[] responses = new bool[answers.Length];
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("NUMBER OF ANSWERS DOES NOT EQUAL NUMBER OF QUESTIONS!");
            };
            int askingIndex = 0;
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                string input = Console.ReadLine();
                bool isBool = Boolean.TryParse(input, out bool inputBool);
                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    string input2 = Console.ReadLine();
                    Boolean.TryParse(input2, out isBool);
                };
                responses.SetValue(inputBool, askingIndex);
                askingIndex++;
            };
            Console.WriteLine(responses[1]);
            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answers[scoringIndex]}");
                if (response == answers[scoringIndex])
                {
                    score++;
                };
                scoringIndex++;
            };
            Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        }
    }
}
