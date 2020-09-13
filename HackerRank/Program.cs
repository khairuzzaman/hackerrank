using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            DaySix();
        }

        private static void DaySix()
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var inputText = Console.ReadLine();
                var stringArray = inputText.ToCharArray();
                var oddText = "";
                var evenText = "";
                var index = 0;
                while (true)
                {
                    oddText += stringArray[index++];
                    if (index > stringArray.Length - 1) break;
                    evenText += stringArray[index++];
                    if (index > stringArray.Length - 1) break;
                }
                Console.WriteLine($"{oddText} {evenText}");
            }
        }
    }
}
