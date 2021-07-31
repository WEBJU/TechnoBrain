using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string comparedTo;
            string defaultInput = "^[a-z]+$";
            Console.WriteLine("Enter a regular expression(or press Enter to use the default): ^[a-z]+$");
            input = Console.ReadLine();
            Console.WriteLine("Enter some input :");
            comparedTo = Console.ReadLine();
            if (comparedTo != "")
            {
                if (CompareForMacth(input, comparedTo)){
                    Console.WriteLine(comparedTo + "matches" +""+ input);
                    Console.WriteLine("Press ESC to end or any key to try again.");
                    Console.ReadKey();
                }
            }
            else
            {
                if (CompareForMacth(input, defaultInput)){
                    Console.WriteLine(comparedTo + "matches" + "" +defaultInput);
                    Console.WriteLine("Press ESC to end or any key to try again.");
                    //String key = Console.ReadKey().Key.ToString();
                    Console.ReadKey();
                }
            }
          

        }
       
        internal static bool CompareForMacth(string value1, string value2)
        {
            if (value1.Length == value2.Length)
            {
                char[] input = value1.ToCharArray();
                char[] comparisonInput = value2.ToCharArray();

                for (int i = 0; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]) && input[i] != input[i])
                    {
                        return false;
                    }
                    else if (Char.IsDigit(comparisonInput[i]) != Char.IsDigit(comparisonInput[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
