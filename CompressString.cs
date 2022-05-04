using System;

namespace CompressString
{
    class Program
    {
        public string compress(string inpStr)
        {
            string retStr = String.Empty;

            int step=0;
            char curChar;
            // int curCount=0;
            // bool resume=true;

            while(true)
            {
                int subStep=1;

                // current char will be the current step of input string
                curChar = inpStr[step];
                
                while(true)
                {

                    bool nextStepIsOutOfLimits = int.Equals(step+subStep, inpStr.Length);
                    // upon reaching the end (next step is out of limits)
                    // write the last character, how many times it occurs, and break the loop
                    if( nextStepIsOutOfLimits )
                    {
                        retStr += curChar.ToString() + subStep.ToString();
                        return retStr;
                    }

                    // compare input string's length and current step
                    // if they're the same break out of the loop
                    if( int.Equals(step+subStep, inpStr.Length) ) { break; }

                    // if the current character equals input string's substep'th value
                    // add one and continue to the next loop
                    bool charsAreSame = char.Equals(curChar, inpStr[step+subStep]);
                    if( charsAreSame ) 
                    {
                        subStep++;
                        continue;
                    }

                    // this part is basically the else block.
                    // adds the current character and the subStep amount 
                    // to the return string
                    retStr += curChar.ToString() + subStep.ToString();
                    step += subStep;
                    subStep=1;
                    break;
                }

            }

        }
    }
}
