using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.InterviewPreparationKit
{
    public class JumpingOnCloud
    {
        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int index = 0;
            int jump = 0;

            while (true)
            {
                if (index >= c.Length) break;
                if(index > 0 && c[index] == 1)
                {
                    index--;
                }

                if(c[index] == 0)
                {
                    jump++;
                    index = index + 2 >= c.Length ? index+1 : index+2;
                }
                else
                {
                    index++;
                }
            }
            
            return jump - 1;
        }

        public static void JumpingOnCloudMain()
        {
            TextWriter textWriter = new StreamWriter("D:\\output.txt", true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
