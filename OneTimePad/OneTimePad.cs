using System;
using System.Text;

namespace OnTimePadProgram
{
    internal class OneTimePad
    {
        private object stringBuilder;

        public OneTimePad()
        {
        }

        public string GetKey(string text)
        {
            StringBuilder builtString = new StringBuilder();

            Random random = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] / 90 < 1)
                {
                    //it's a capitol letter.
                    builtString.Append((char)random.Next('A', 'A' + 26));
                }
                else
                {
                    //it's a lower case letter.
                    builtString.Append((char)random.Next('a', 'a' + 26));
                }
            }


            return builtString.ToString();
        }

        public string Encrypt(string textToEncrypt, string key)
        {
            StringBuilder builtString = new StringBuilder();



            return builtString.ToString();
        }
    }
}