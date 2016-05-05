using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateClassGenerator.Helpers
{
    public class TextHelper
    {
        public static string FirstLetterUp(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string[] words = text.Split('_');

            string textResult = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {                
                string fistLetter = words[i];
                if (!string.IsNullOrEmpty(fistLetter))
                    fistLetter = fistLetter.First().ToString().ToUpper();                
               
                if (words[i].Length > 1)
                    textResult = textResult + fistLetter + words[i].Substring(1);
                else
                    textResult = textResult + fistLetter + words[i];

                if (words.Length > 1 && words.Length-1 != i)
                    textResult = textResult + "_";
            }

            return textResult;
        }
    }
}
