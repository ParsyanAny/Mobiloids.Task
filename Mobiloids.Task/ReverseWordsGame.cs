using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiloids.Task
{
    static class ReverseWordsGame
    {
        public static int ReversePairsCount(List<string> words)
        {
            int count = 0;

            for (int i = 0; i < words.Count - 1; i++)
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (words[i] != "" && words[j] != "" &&
                        new string(words[i].ToCharArray().Reverse().ToArray()) == words[j])
                    {
                        count++;
                        words[i] = "";
                        words[j] = "";
                    }
                }
            }
            return count;
        }

    }
}
