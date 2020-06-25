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

            Console.WriteLine(MyStringCheck(EnterYourString()));
        }
        // ==============================================================================
        private static string MyStringCheck(string str)
        {
            if (str.Contains("ss"))
                return "hiss";
            else return "no hiss";
        }
        // ==============================================================================

        private static string EnterYourString()
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
                if (MyStringConditions(str) == false)
                    throw new FormatException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterYourString();
            }
            return str;
        }

        private static bool MyStringConditions(string str)
        {
            if (str.Length < 1 || str.Length > 30)
                return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]) == false)
                    return false;
            }
            return true;
        }
    }
}
