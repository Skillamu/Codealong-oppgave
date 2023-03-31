namespace Codealong_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quiz = new Quiz();
            quiz.Run();

            Console.ReadKey(true);
        }
    }
}