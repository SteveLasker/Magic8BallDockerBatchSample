using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic8Ball
{
    public class Program
    {
        static Random _r = new Random();
        public static void Main(string[] question)
        {
            EightBallAnswers answers = new EightBallAnswers();
            int rInt = _r.Next(0, answers.Count() - 1);
            string response;
            if (question.Length == 0)
            {
                response = "You must ask a question to be provided an answer.";
            }
            else
            {
                response = string.Format("The answer to your question: '{0}' is {1}", question[0], answers[rInt]);
            }
            Console.WriteLine( response);
        }
    }
}
