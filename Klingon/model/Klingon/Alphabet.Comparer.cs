
using System;
using System.Collections.Generic;
using Klingon.Alphabet.Structure;
namespace Klingon.Alphabet.Comparer
{
    public class KlingonComparer : IComparer<string>
    {
        public int Compare(string word1, string word2)
        {
            if (word1 == null)
            {
                return word2 == null ? 0 : -1;
            }

            if (word2 == null)
            {
                return 1;
            }

            int minLength = Math.Min(word1.Length, word2.Length);

            for (int index = 0; index < minLength; index++)
            {
                int indexWord1 = AlphabetOrder.Get().IndexOf(word1[index]);
                int indexWord2 = AlphabetOrder.Get().IndexOf(word2[index]);

                if (indexWord1 == -1)
                {
                    throw new Exception(word1);
                }

                if (indexWord2 == -1)
                {
                    throw new Exception(word2);
                }

                int compare = indexWord1.CompareTo(indexWord2);

                if (compare != 0)
                {
                    return compare;
                }
            }

            return word1.Length.CompareTo(word2.Length);
        }
    }
}