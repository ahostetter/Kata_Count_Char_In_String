using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharacterInString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Count("AdamAAASSDFSSDFAslkdfoaasdflsdf"));
        }

        static string Count(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (char letter in str.ToLower())
            {
                if (!dict.ContainsKey(letter))
                {
                    dict.Add(letter, 1);
                }
                else
                    dict[letter] = dict[letter] + 1;
            }

            string output = "";

            foreach (KeyValuePair<char, int> pair in dict)
            {
                output += string.Format("'{0}': {1}, ", pair.Key, pair.Value);
            }
            return output;
        }
    }
}
