using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codemoney
{
    public class Solution
    {
        public static string Encoded(string text)
        {
            string FirstSub = text.Substring(0, (text.Length / 2));
            string SecondSub = text.Substring((text.Length / 2));
            string NewA = "";
            string NewB = "";

            for (int i = 0; i < FirstSub.Length; i++)
            {
                if (i % 2 == 0)
                {
                    NewA += FirstSub[i] + "" + SecondSub[i];
                    continue;
                }
                    NewB += FirstSub[i] + "" + SecondSub[i];
            }
            string concat = string.Concat(NewB, NewA);
            Console.WriteLine(concat);
            return concat;

        }
        public static void Decode(string concat)
        {
            string letters = Encoded(concat);
            string ThirdSub = letters.Substring(0, (letters.Length / 2));
            string FourthSub = letters.Substring((letters.Length/2));
            string newc = "";
            string newd = "";
            for (int i = 0; i < FourthSub.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newd += FourthSub[i] + "" + ThirdSub[i];
                    continue;
                }
                newc += FourthSub[i] + "" + ThirdSub[i];
            }
            string concatination = string.Concat(newc, newd);
            Console.WriteLine(concatination);
        }

    }
}