using System;

namespace MixTwoStrings
{
    class Program
    {
        public string mix(string inpStr1, string inpStr2)
        {
            // initialize empty string
            string retStr = string.Empty;

            int step=0;
            foreach (char c in inpStr1)
            {
                retStr+=c;

                // try to add a char from input string 2. upon failure, just continue. 
                try{ retStr+=inpStr2[step]; } catch(Exception) { /*PASS*/; } ;

                step++;
            }

            return retStr;
        }
    }
}
