using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSubstring
{
    public class ManageStrings
    {
        public string Find(string textToSearch, string subtext)
        {
            try
            {
                string textToSearchU = textToSearch.ToUpper();
                string subtextU = subtext.ToUpper();
                int subtextLen = subtext.Length;

                char[] textToSearchChar = textToSearchU.ToCharArray();
                char[] subtextChar = subtextU.ToCharArray();

                List<int> potentialHits = FirstLetterHits(textToSearchChar, subtextChar);
                List<int> hits = new List<int>();

                foreach (var item in potentialHits)
                {
                    if (VeriFyHits(textToSearchChar, subtextChar, item, subtextLen))
                    {
                        hits.Add(item + 1); // To base 1
                    }
                }

                string found = string.Join(",", hits.Select(n => n.ToString()).ToArray());

                Console.WriteLine("{0} => {1}", subtext, found);

                return found;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private List<int> FirstLetterHits(char[] textToSearchChar, char[] subtextChar)
        {
            List<int> hits = new List<int>();

            for (int i = 0; i <= textToSearchChar.Length - 1; i++)
            {
                if (textToSearchChar[i] == subtextChar[0])
                {
                    hits.Add(i);
                }
            }

            return hits;
        }

        private bool VeriFyHits(char[] textToSearchChar, char[] subtextChar, int offset, int subtextLen)
        {
            for (int i = 0; i < subtextLen; i++)
            {
                if (textToSearchChar[i + offset] != subtextChar[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
