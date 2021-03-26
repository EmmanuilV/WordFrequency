using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequency
{
    class Frequency
    {
        //private string keyValue;

        public void WordFrequency(string text)
        {
            string[] symbRemove = new string[] {",", "."};
            foreach (string symb in symbRemove)
            {
                text = text.Replace(symb, string.Empty);
            }
            List<string> words = text.Split(" ").ToList().ConvertAll(d => d.ToLower());

            Dictionary<string, int> wordsList = new Dictionary<string, int>();

            foreach (string word in words)
            {
                
                if (wordsList.ContainsKey(word))//if(wordsList.TryGetValue(word, out int count))
                {
                    wordsList[word]++;
                }
                else
                {
                    wordsList.Add(word, 1);
                }
            }
            foreach (KeyValuePair<string, int> word in wordsList)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
            //return keyValue;
            /*keyValue = $"{word.Key} - {word.Value}";
                return keyValue;*/

        }
    }
}
