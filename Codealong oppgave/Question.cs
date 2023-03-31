using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong_oppgave
{
    internal class Question
    {
        private string _question;
        private string _correctAnswer;
        private string[] _alternatives;

        public Question(string question, string correctAnswer, params string[] alternatives)
        {
            _question = question;
            _correctAnswer = correctAnswer;
            _alternatives = alternatives;
        }

        public void QuestionText()
        {
            Console.WriteLine(_question);
        }

        public void PossibleAlternatives()
        {
            var index = 0;
            foreach (string alternative in _alternatives)
            {
                var letter = Convert.ToChar('A' + index);
                Console.WriteLine($"{letter}: {alternative}");
                index++;
            }
            Console.WriteLine("Skriv inn en av de mulige alternativene, f.eks \"A\"");
        }

        public int CheckAnswerFromUser()
        {
            var answer = Console.ReadLine();

            var correctAnswer = answer == _correctAnswer;
            var points = 0;

            if (!correctAnswer)
            {
                Console.WriteLine("Feil!\n");
                return points;
            }

            Console.WriteLine("Riktig!\n");
            return ++points;
        }
    }
}
