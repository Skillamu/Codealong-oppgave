﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong_oppgave
{
    internal class Quiz
    {
        private Question[] _questions;
        public Quiz()
        {
            _questions = new Question[]
            {
                new Question("Hva er 2+2?", "C", "2", "3", "4"),
                new Question("Hvilken by er norsk?", "A", "Oslo", "Ohio", "Omaha"),
                new Question("Hvilken farge er ikke i det norske flagget?", "B", "Rød", "Grønn", "Blå"),
            };
        }

        public void Run()
        {
            int points = 0;
            foreach (var question in _questions)
            {
                          question.QuestionText();
                          question.PossibleAlternatives();
                points += question.CheckAnswerFromUser();
            }
            Console.WriteLine($"Du fikk {points} riktig.");
        }
    }
}
