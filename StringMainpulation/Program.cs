using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StringMainpulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IsEndDot("Hello World!"));
            //Console.WriteLine(IsEndDot("Hello World."));


            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å",new CultureInfo("en-GB"), true));
            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å",new CultureInfo("en-GB"), false));
            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å", new CultureInfo("en-AU"), true));
            //Console.WriteLine(CheckEndString( "abcЙࠉ", "Å",new CultureInfo("en-AU"), false));

            //Console.WriteLine(CheckEndString("xyzPQR", "PQR", new CultureInfo("en-AU"), false));

        }


        //Q1
        public static void CompareStrings(string str1, string str2)
        {
            Console.WriteLine(str1.ToLower() == str2.ToLower() || str1.ToLower() == str2.ToLower() ? true : false);
        }

        //Q2
        public static void CompareLetterInWord(string str1, string str2)
        {
            CultureInfo USA = new CultureInfo("en-US");
            CultureInfo Czech = new CultureInfo("cs-CZ");

            Console.WriteLine("For cs-CZ:{0}", (String.Compare(str1, str2, false, Czech)) == 1 ? str1 + " > " + str2 : str1 + " < " + str2);

        }

        //Q3
        public static void CompareStringsInMultipleWays(string str1, string str2)
        {
            Console.WriteLine(String.Compare(str1, str2, StringComparison.CurrentCulture) == 1 ? str1 + " Comes before " + str2 : str1 + " Comes after " + str2);
            Console.WriteLine(String.Compare(str1, str2, StringComparison.CurrentCultureIgnoreCase) == 1 ? str1 + " is the same as " + str2 : str1 + " is not the same as " + str2);
            Console.WriteLine(String.Compare(str1, str2, StringComparison.Ordinal) == 1 ? str1 + " Comes before " + str2 : str1 + " Comes after " + str2);


        }

        //Q4


        //Q5
        public static void CompareAndCompareordinals()
        {
            Console.WriteLine(String.CompareOrdinal("xyz"[1].ToString(), "XYZ"[1].ToString()) > 0 ? "xyz"[1] + " is greater than " + "XYZ"[1] : "xyz"[1] + " is less than " + "XYZ"[1]);
            Console.WriteLine(String.Compare("xyz"[1].ToString(), "XYZ"[1].ToString()) > 0 ? "xyz"[1] + " is greater than " + "XYZ"[1] : "xyz"[1] + " is less than " + "XYZ"[1]);


        }




        //Q15
        static bool IsEndDot(string input)
        {
            return input.EndsWith(".");
        }

        //Q16 need to check more
        static bool CheckEndString(
            string input,
            string target,
            CultureInfo culture,
            bool isSensitive)
        {
            return input.EndsWith(target, isSensitive, culture);
        }

        //Q17 
        static string CheckParticularSubstring(
            string input,
            string target,
            CultureInfo culture,
            bool isSensitive)
        {
            return input.EndsWith(target, isSensitive, culture) ?
                $"'{input}' ends with '{target}'." :
                $"'{input}' not ends with '{target}'.";
        }

        //Q19
        static string ReverseAndUpperWords2(string input)
        {
            return string.Concat(input.Reverse()).ToUpper();
        }


        //Q20
        static string RemoveDuplicateLetters(string input)
        {
            return string.Concat(input.Distinct());
        }

        //Q21


        //Q22
        static string ReverseTheCaseForLetters(string input)
        {
            string reversedString = "";

            foreach (var letter in input)
            {
                reversedString += char.IsUpper(letter) ? char.ToLower(letter) : char.ToUpper(letter);
            }

            return reversedString;
        }


        //Q22
        public static string ReverseTheCaseForLetters2(string text)
        {
            return string.Concat(text.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)));
        }


        //Q23
        public static string GetCentralCharacter(string text)
        {
            int l = 1 - text.Length % 2;
            return text.Substring(text.Length / 2 - l, 1 + l);
        }

        //Q24
        public static string GetMinimumAndMaximumNumberWords(string str_num)
        {
            var result = str_num.Split(' ').Select(int.Parse).ToArray();
            return result.Max() + ", " + result.Min();
        }

        //Q25
        public static bool Isisograms(string str1)
        {
            int str_len = str1.Length;
            return str1.ToLower().Distinct().Count() == str_len;
        }

        //Q26
        public static string ConvertFirstLetterToUpper(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }

        //Q27
        public static int GetPositionWord(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }

        //Q28
        public static string CovertOddLettersInWordtoUpper(string str)
        {
            string text = str.Replace(" ", "  ");
            string result_str = "";
            result_str += Char.ToUpper(str[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0) result_str += Char.ToUpper(text[i]);
                else if (i % 2 != 0 && Char.IsUpper(text[i])) result_str += Char.ToLower(text[i]);
                else result_str += text[i];
            }
            result_str = result_str.Replace("  ", " ");
            return result_str;
        }


        //Q29
        public static string reversWordsEvenLenght(string text)
        {
            return string.Join(" ", text.Split(' ').Select(str => str.Length % 2 != 0 ? str : new String(str.Reverse().ToArray())));
        }

        //Q30
        public static string LongesCommonEndingBetweenWords(string st1, string st2)
        {
            for (int i = 0; i < st1.Length; i++)
            {
                string end = st1.Substring(i);
                if (st2.EndsWith(end))
                {
                    return end;
                }
            }
            return "";
        }

    }

}
