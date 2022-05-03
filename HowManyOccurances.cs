using System;

namespace HowManyOccurances
{
    class Program
    {
        public int howMany(string inpStrText, string inpStrWord)
        {
            // string retStr = string.Empty;
            int retInt=0;

            // split text into array of strings containing each word in a diff string
            string[] textInArray = inpStrText.Split(new char[]{' '} );

            // compare each string to the word being counted. if same, adds 1
            foreach (string s in textInArray)
            {
                if ( String.Equals(s, inpStrWord) ) 
                {
                    retInt++;
                }
            }

            return retInt;
        }
    }
}
