using System;
using System.Collections.Generic;
using Leet;

namespace Leet
{
    public class LeetTranslator
    {
        public string TranslateLetter (string input)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i<inputArray.Length; i++)
            {
                if (inputArray[i] == (char) 'e' || inputArray[i] == (char) 'E')
                {
                    inputArray[i] = (char) '3';
                }
                if (inputArray[i] == (char)'o' || inputArray[i] == (char)'O')
                {
                    inputArray[i] = (char)'0';
                }
                if (inputArray[i] == (char)'t' || inputArray[i] == (char)'T')
                {
                    inputArray[i] = (char) '7';
                }
                if (inputArray[i] == (char)'I')
                {
                    inputArray[i] = (char) '1';
                }
                
                if (inputArray[i] == (char)'S' || inputArray[i] == (char)'s')
                {
                    if (i != 0)
                    {
                    inputArray[i] = (char)'z';
                    }
                }
            }
            string result = string.Join("", inputArray);
            return result;

        }
        public string SplitPhraseToWords(string input)
        {
            string outputPhrase= "";
            string[] inputSplit = input.Split(" ");
            for (int i = 0; i < inputSplit.Length; i++)
            {
             string Word = TranslateLetter(inputSplit[i]);    
             outputPhrase += Word + " ";
            }
            return outputPhrase;
        }
    }
}
