using HackerRank.InterviewPreparationKit;
using System;

namespace HackerRank
{
    class Program
    {
        // test comments
        static void Main(string[] args)
        {
            //DaySeven();
            //DaySix();

            #region Interview preparation kit
            RepeatedString.RepeatedStringMain();
            //JumpingOnCloud.JumpingOnCloudMain();
            //SalesbyMatch.SalesbyMatchMain();
            #endregion
        }

        private static void DaySeven()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            for(var i = arr.Length - 1; i >= 0; i--)
            {
                var space = i == 0 ? "" : " ";
                Console.Write($"{arr[i]}{space}");
            }
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
