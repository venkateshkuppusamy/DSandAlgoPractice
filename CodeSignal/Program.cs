using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(new string[] { "cat", "dog" }, "there is a cat, rabbit, and another rabbit");
            //var result = solution(new string[] { "one", "two", "three", "four" }, "five, six, seven!");
            Console.WriteLine(result[0] + ","+ result[1]);
            Console.ReadLine();
        }

        static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        static int[] solution(string[] words, string sentense)
        {
            //sentense = sentense.Replace(",", "");
            sentense = RemoveSpecialCharacters(sentense);
            string[] arrSentense = sentense.Split(" ");
            HashSet<string> mapWords = new HashSet<string>(words);           HashSet<string> mapSentense = new HashSet<string>();            HashSet<string> mapSentense2 = new HashSet<string>();
            int uniqueWordCount = 0;            int uniqueWordCountFromWords = 0;
            for (int i = 0; i < arrSentense.Length; i++)
            {
                if (!mapWords.Contains(arrSentense[i]))
                {
                    if (!mapSentense.Contains(arrSentense[i]))
                    {
                        mapSentense.Add(arrSentense[i]);
                        uniqueWordCount++;
                    }
                }
                else
                {
                    if (!mapSentense2.Contains(arrSentense[i]))
                    {
                        mapSentense2.Add(arrSentense[i]);
                        uniqueWordCountFromWords++;
                    }
                }
            }
            return new int[2]{uniqueWordCount,uniqueWordCountFromWords };
        }
    }
}
