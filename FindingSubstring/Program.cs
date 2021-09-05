using System;

namespace FindingSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageStrings mStrings = new ManageStrings();

            mStrings.Find("Peter told me (actually he slurrred) that peter the pickle piper piped a pitted pickle before he petered out. Phew!", "peter");
        }
    }
}
