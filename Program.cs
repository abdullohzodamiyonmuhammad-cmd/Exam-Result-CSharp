using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Системаи муайянкунии натиҷаи имтиҳон ===");
            Console.WriteLine("Баҳо аз 0 то 100 ворид карда мешавад.");
            Console.WriteLine("Барои баромадан 'q' ворид кунед.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Баҳои донишҷӯ: ");
                string input = Console.ReadLine();
                input = (input == null) ? "" : input.Trim();

                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                    break;

                int score;
                if (!int.TryParse(input, out score))
                {
                    Console.WriteLine("Хато: адади бутун ворид кунед.");
                    Console.WriteLine();
                    continue;
                }

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Хато: баҳо бояд аз 0 то 100 бошад.");
                    Console.WriteLine();
                    continue;
                }

                string result = GetResult(score);

                Console.WriteLine();
                Console.WriteLine("Баҳо:    " + score);
                Console.WriteLine("Натиҷа:  " + result);
                Console.WriteLine("Эзоҳ:    " + GetComment(result));
                Console.WriteLine();
            }

            Console.WriteLine("Хайр!");
        }

        private static string GetResult(int score)
        {
            if (score >= 90)
            {
                return "Аъло";
            }
            else if (score >= 70)
            {
                return "Хуб";
            }
            else if (score >= 50)
            {
                return "Қаноатбахш";
            }
            else
            {
                return "Ноком";
            }
        }

        private static string GetComment(string result)
        {
            switch (result)
            {
                case "Аъло":
                    return "Офарин! Натиҷаи аъло.";

                case "Хуб":
                    return "Кори хуб, каме бештар кӯшиш кунед.";

                case "Қаноатбахш":
                    return "Имтиҳонро супоридед, аммо такрор кардан лозим аст.";

                case "Ноком":
                    return "Имтиҳон супурда нашуд, дубора омода шавед.";

                default:
                    return "";
            }
        }
    }
}