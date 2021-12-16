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
            Console.WriteLine(lines);

            while (true)
            {
                Console.WriteLine("Enter an input:");
                string input = Console.ReadLine();
                Console.WriteLine(TESTModule(input));
            }
        }

        public static string TESTModule(string value)
        {
            switch (value)
            {
                // A. For integer 1,2,3,4 
                case var expression when int.TryParse(value, out _) ? Convert.ToInt32(value) > 0 && Convert.ToInt32(value) < 5 : false:
                    return $"{Convert.ToInt32(value) * 2}";
                    break;
                // B. For integers bigger than 4
                case var expression when int.TryParse(value, out _) ? Convert.ToInt32(value) > 4 : false:
                    return $"{Convert.ToInt32(value) * 3}";
                    break;
                // C. For integers below 1
                case var expression when int.TryParse(value, out _) ? Convert.ToInt32(value) < 1 : false:
                    Exception ex = new Exception("Value can't be less than 1");
                    throw (ex);
                // D. For float values of 1.0f and 2.0f 
                case var expression when float.TryParse(value, out _) ? float.Parse(value) == 1.0f || float.Parse(value) == 2.0f : false:
                    return $"{3.0f}";
                    break;
                // E. For float values of 1.0f and 2.0f 
                case var expression when value is string:
                    return value.ToUpper();
                    break;
                default:
                    return value;
                    break;
            }
            return "";
        }
    }
}
