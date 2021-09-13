using System;
using System.Text;

namespace OnTimePadProgram
{
    public class OneTimePad
    {
        public OneTimePad()
        {
        }

        public string GetKey(string text)
        {
            StringBuilder builtString = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < text.Length;)
            {
                bool isUnique = true;
                char randomChar;
                if (text[i] / 90 < 1)
                {
                    //it's a capitol letter.
                    randomChar = (char)random.Next('A', 'A' + 26);
                }
                else
                {
                    //it's a lower case letter.
                    randomChar = (char)random.Next('a', 'a' + 26);
                }

                for (int j = 0; j < i; j++)
                {
                    if (builtString[j] == randomChar)
                    {
                        isUnique = false;
                    }
                }

                if (isUnique)
                {
                    builtString.Append(randomChar);
                    i++;
                }   
            }
            return builtString.ToString();
        }

        public string Decrypt(string textToDecrypt, string key)
        {
            StringBuilder builtString = new StringBuilder();

            for (int i = 0; i < textToDecrypt.Length; i++)
            {
                int charValue = textToDecrypt[i];
                int padValue = key[i];

                if (textToDecrypt[i] / 90 < 1)
                {
                    char charToAppend = (char)(26 + charValue - padValue + 'A');
                    builtString.Append(charToAppend);
                }
                else
                {
                    char charToApped = (char)(26 + (charValue - padValue) + 'a');
                    builtString.Append(charToApped);
                }
            }
            return builtString.ToString();
        }

        public string Encrypt(string textToEncrypt, string key)
        {
            StringBuilder builtString = new StringBuilder();

            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                int charValue = textToEncrypt[i];
                int padValue = key[i];

                if (textToEncrypt[i] / 90 < 1)
                {
                    charValue = charValue - 'A';
                    padValue = padValue - 'A';

                    int newCharValue = (charValue + padValue) % 26;
                    char charToAppend = (char)(newCharValue + 'A');
                    builtString.Append(charToAppend);
                }
                else
                {
                    charValue = charValue - 'a';
                    padValue = padValue - 'a';

                    int newCharValue = (charValue + padValue) % 26;
                    char charToAppend = (char)(newCharValue + 'a');
                    builtString.Append(charToAppend);
                }
            }

            return builtString.ToString();
        }
    }
}