using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.InterviewPreparationKit
{
    public class SalesbyMatch
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var socksPair = new Dictionary<int, int>();
            for(int i = 0; i < n; i++)
            {
                if (socksPair.ContainsKey(ar[i]))
                {
                    socksPair[ar[i]]++;
                }
                else
                {
                    socksPair.Add(ar[i], 1);
                }
            }

            var result = 0;
            foreach(var item in socksPair)
            {
                result = result + item.Value / 2;
            }
            return result;
        }

        public static void SalesbyMatchMain()
        {
            TextWriter textWriter = new StreamWriter("D:\\output.txt", true);
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

