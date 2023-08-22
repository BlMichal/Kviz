using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovani
{
    public class Question
    {

        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string text, List<string> options, int correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
