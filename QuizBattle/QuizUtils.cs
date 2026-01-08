using System;
using System.Collections.Generic;

namespace QuizBattle
{
    public static class QuizUtils
    {
        private static List<Question> _questions = new List<Question>();
        private static int _player1Score;
        private static int _player2Score;
        private static int _currentPlayer = 1;
        private static int _questionIndex;

        public static bool IsCompleted()
        {
            return _questionIndex >= _questions.Count;
        }

        public static void DisplayQuestion()
        {
            var question = _questions[_questionIndex];
            Console.WriteLine($"Fråga {_questionIndex + 1}: {question.Statement}");
            for (int i = 0; i < question.Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Choices[i].Text}");
            }
        }

        public static string GetAnswer()
        {
            Console.Write($"Spelare {_currentPlayer}, välj ett alternativ: ");
            return Console.ReadLine() ?? "";
        }

        public static void CheckAnswer(string answer)
        {
            if (int.TryParse(answer, out int choice) && choice - 1 == _questions[_questionIndex].CorrectAnswerIndex)
            {
                if (_currentPlayer == 1)
                {
                    _player1Score++;
                }
                else
                {
                    _player2Score++;
                }

                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }

            _questionIndex++;
            _currentPlayer = _currentPlayer == 1 ? 2 : 1;
        }

        public static void WriteStatus()
        {
            Console.WriteLine($"Poängställning: Spelare 1: {_player1Score} - Spelare 2: {_player2Score}");
        }

        public static void SeedQuestions()
        {
            _questions = new List<Question>
            {
                new Question("Hur många ben har en spindel?", new List<Choice> { new Choice("6"), new Choice("8"), new Choice("10") }, 1),
                new Question("Vilken är den största planeten i vårt solsystem?", new List<Choice> { new Choice("Jorden"), new Choice("Mars"), new Choice("Jupiter") }, 2)
            };
        }
    }
}
