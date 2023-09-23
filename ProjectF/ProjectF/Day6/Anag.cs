﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectF.Day6
{
    internal class Anag
    {
        public static void Anagf()
        {

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            List<string> words = sentence.Split(' ').ToList();
            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sortedWord = new string(charArray);

                if (!anagramGroups.ContainsKey(sortedWord))
                {
                    anagramGroups[sortedWord] = new List<string>();
                }

                anagramGroups[sortedWord].Add(word);
            }

            Console.WriteLine("Anagram groups in the sentence:");
            foreach (var group in anagramGroups.Values)
            {
                if (group.Count > 1)
                {
                    Console.WriteLine(string.Join(", ", group));
                }
            }
        }
    }
}
