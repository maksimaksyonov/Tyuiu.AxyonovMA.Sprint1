using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.AxyonovMA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLastLetterToStart(string value)
        {
            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    string word = words[i];
                    char lastLetter = word[word.Length - 1];
                    words[i] = lastLetter + word.Substring(0, word.Length - 1);
                }
            }

            return string.Join(" ", words);
        }

        public string MoveLetterToStart(string value)
        {
            throw new NotImplementedException();
        }
    }
}