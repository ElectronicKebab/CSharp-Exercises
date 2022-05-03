using System;

namespace SortCharactersDescending
{
    class Program
    {
        public char[] sort(string inpStr)
        {
            char[] retCharArr;

            retCharArr = inpStr.ToCharArray();
            Array.Sort(retCharArr, StringComparer.Ordinal);

            return retCharArr;
        }
    }
}
