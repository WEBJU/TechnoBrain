using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class Exercise03
    {
        public static void main(String[] args)
        {
            string isNegative = "";
            try
            {
                Console.WriteLine("Enter a Number to convert to words");
                string number = Console.ReadLine();
                number = Convert.ToDouble(number).ToString();

                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    Console.WriteLine("The number in words is \nZero ");
                }
                else
                {
                    Console.WriteLine("The number in words is \n{0}", isNegative + Exercise02.ConvertToWords(number));
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
      
        }
    }


