using QuizBattle;

QuizUtils.SeedQuestions();

System.Console.WriteLine("Välkommen till Quiz Battle!");

System.Console.WriteLine("Quiz Battle regler:");
System.Console.WriteLine("1. Du och din motståndare turas om att svara på frågor.");
System.Console.WriteLine("2. Varje rätt svar ger 1 poäng.");

while (!QuizUtils.IsCompleted())
{
    QuizUtils.DisplayQuestion();
    var answer = QuizUtils.GetAnswer();

    QuizUtils.CheckAnswer(answer);

    QuizUtils.WriteStatus();
}

System.Console.WriteLine("Tack för att du spelade Quiz Battle!");

