    namespace QuizBattle
{
    public class Question
    {
        public string Statement { get; set; }
        public System.Collections.Generic.List<Choice> Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string statement, System.Collections.Generic.List<Choice> choices, int correctAnswerIndex)
        {
            Statement = statement;
            Choices = choices;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}

