using System;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Alternative ForEach ###");
            QuestionClass.NamesList.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("### Join ###");
            string lines = string.Join(Environment.NewLine, QuestionClass.NamesList);
            Console.Write(lines);
        }
    }
}
