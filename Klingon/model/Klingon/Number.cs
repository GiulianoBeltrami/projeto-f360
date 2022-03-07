using System;
using System.Collections.Generic;
using System.Linq;
using Klingon.Alphabet.Structure;
using TextHandler;

namespace Klingon.Numbers
{
    public class Number
    {
        private List<double> _numbers = new List<double>();
        private List<double> _beautifulNumbers = new List<double>();

        public List<double> GetAll(string text)
        {
            ProcessTextAsNumber(text);
            return _numbers.Distinct().ToList();
        }

        public List<double> GetBeautiful(string text)
        {
            ProcessTextAsNumber(text);
            return _beautifulNumbers.Distinct().ToList();
        }

        private void ProcessTextAsNumber(string text)
        {
            Dictionary<char, int> alphabetWithNumbers = AlphabetOrder.GetAlphabetWithNumber();
            List<double> textNumbers = new List<double>();

            string[] splitedText = TextFormatter.LowerTextAndSplit(text);

            for (int i = 0; i < splitedText.Length; i++)
            {
                char[] chars = splitedText[i].ToCharArray();
                double klingonNumber = 0;

                for (int j = 0; j < chars.Length; j++)
                {
                    int charValue = alphabetWithNumbers.GetValueOrDefault(chars[j]);
                    klingonNumber += charValue * (Math.Pow(20, j));
                }

                if (IsBeautifulNumber(klingonNumber))
                {
                    _beautifulNumbers.Add(klingonNumber);
                }

                _numbers.Add(klingonNumber);

            }
        }

        private bool IsBeautifulNumber(double number)
        {
            return IsGreaterOrEqual440566(number) && IsDivisibleByThree(number);
        }

        private bool IsGreaterOrEqual440566(double number)
        {
            return number >= 440566;
        }

        private bool IsDivisibleByThree(double number)
        {
            return number % 3 == 0;
        }


    }
}