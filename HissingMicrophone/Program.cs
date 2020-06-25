using System;

namespace HissingMicrophone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hissing Microphone
            // https://open.kattis.com/problems/hissingmicrophone 
            // two successive chars compare in a string
            while (true)
            {
                Console.WriteLine(MyStringCheck(Console.ReadLine()));
            }
        }
        private static string MyStringCheck(string str)
        {
            if (str.Contains("ss"))
                return "hiss";
            else return "no hiss";
        }
    }
}
