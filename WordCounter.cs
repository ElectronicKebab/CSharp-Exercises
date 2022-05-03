using System;

namespace WordCounter
{
    class Program
    {
        public int count(string inpStr)
        {
            // string retStr = string.Empty;
            int retInt=0;

            foreach (char c in inpStr)
            {
                // if c = space jumps to next loop, else adds 1 to retInt.
                if( Convert.ToBoolean( ' '.CompareTo(c) ) ) continue; else retInt++;
            }

            // return one more since word count = space count + 1
            return retInt+1;
        }
    }
}
