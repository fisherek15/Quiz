using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] questionsAndAnswers = new string[3, 2]
            {
                {"1. Ile lat ma Zenek?", "A: 10 lat\nB: 12 miesięcy\nC: 5 lat\nD: 8 lat\n" },
                {"2. Ile wynosi pierwiastek z 4?", "A: 3\nB: 8\nC: nie da się obliczyć\nD: 2\n" },
                {"3. Ile spotkań zostało przewidzianych na to szkolenie?", "A: nie określono\nB: 8\nC: 12\nD: 5\n" },
            };

            Dictionary<int, string> goodAnswers = new Dictionary<int, string>();
            goodAnswers.Add(1, "C");
            goodAnswers.Add(2, "D");
            goodAnswers.Add(3, "B");

            Queue<string> userAnswers = new Queue<string>();

            for( int i = 0; i < 3; i++)
            {
                Console.WriteLine(questionsAndAnswers[i, 0]);
                Console.WriteLine(questionsAndAnswers[i, 1]);               
                // dodać pętle
                string userAnswer = ValidateKey();
                userAnswers.Enqueue(userAnswer);
                Console.WriteLine();
            }

            foreach(var answer in goodAnswers)
            {
                Console.WriteLine("Twoja odpowiedź na pytanie nr " + answer.Key + " to: " + userAnswers.Dequeue() + " - poprawna odpowiedź to: " + answer.Value);
            }
            
        }

        static string ValidateKey()
        {
            string character;
            List<string> characters = new List<string>(new string[] { "A", "B", "C", "D" });
            do
            {
                Console.Write("Odpowiedź: ");
                character = Console.ReadLine().ToUpper();
                if (characters.Contains(character))
                {
                    return character;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy znak. Wprowadź A, B, C lub D.");
                }
            } while (true);            
        }
    }
}
