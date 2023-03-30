namespace Codealong_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var question1 = new Question("Hva er 2+2?", "C", "2", "3", "4");
            var question2 = new Question("Hvilken by er norsk?", "A", "Oslo", "Ohio", "Omaha");
            var question3 = new Question("Hvilken farge er ikke i det norske flagget?", "B", "Rød", "Grønn", "Blå");

            Question[] questions = { question1, question2, question3 };

            var points = 0;
            foreach (Question question in questions)
            {
                question.QuestionText();
                question.PossibleAlternatives();
                points += question.CheckAnswerFromUser();
            }
            Console.WriteLine($"Du fikk {points} riktig.");

            Console.ReadKey(true);
        }
    }
}