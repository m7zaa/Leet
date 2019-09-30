using System;
using System.Collections.Generic;
using Leet;

namespace Leet
{
    public class LeetTranslator
    {
        public string TranslateETo3 (string input)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i<inputArray.Length; i++)
            {
                if (inputArray[i] == (char) 'e' || inputArray[i] == (char) 'E')
                {
                    inputArray[i] = (char) '3';
                }
            }
            string result = string.Join("", inputArray);
            return result;
        }
    }
}
