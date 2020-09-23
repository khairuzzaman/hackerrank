using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HackerRank.InterviewPreparationKit
{
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            var acount = s.ToCharArray().Where(c => c == 'a').Count();
            var multiplier = n / s.Length;
            var remainder = n % s.Length;

            var remainingCount = s.Substring(0, (int)remainder).ToCharArray().Where(c => c == 'a').Count();
            
            return acount * multiplier + remainingCount;
        }

        public static void RepeatedStringMain()
        {
            TextWriter textWriter = new StreamWriter("D:\\output.txt", true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
