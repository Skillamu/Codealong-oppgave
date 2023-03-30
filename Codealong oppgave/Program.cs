namespace Codealong_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var points = 0;

            AskQuestion("Hva er 2+2?");
            PossibleAnswers("2", "3", "4");
            Console.WriteLine("Skriv inn a, b eller c: ");
            points += CheckAnswer("c");

            AskQuestion("Hvilken by er norsk?");
            PossibleAnswers("Oslo", "Ohio", "Omaha");
            Console.Write("Skriv inn a, b eller c: ");
            points += CheckAnswer("a");

            AskQuestion("Hvilken farge er ikke i den norske flagget?");
            PossibleAnswers("Rød", "Grønn", "Blå");
            Console.Write("Skriv inn a, b eller c: ");
            points += CheckAnswer("b");

            Console.WriteLine($"Du fikk {points} riktige."); 
             

            Console.ReadKey(true);
        }

        static void PossibleAnswers(params string[] alternatives)
        {
            var index = 0;
            foreach (string alternative in alternatives)
            {
                var letter = Convert.ToChar('A' + index);
                Console.WriteLine($"{letter} {alternative}");
                index++;
            }
        }

        static int CheckAnswer(string correctAnswer)
        {
            var answer = Console.ReadLine();
            if (answer == correctAnswer)
            {
                Console.WriteLine("Riktig!");
                return 1;
            }

            Console.WriteLine("Feil!");
            return 0;
        }

        static void AskQuestion(string question)
        {
            Console.WriteLine(question);
        }
    }
}