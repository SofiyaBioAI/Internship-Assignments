using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderApp
{
    public class StringReverser
    {
        public string ReverseSentence(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
            {
                return sentence;
            }

            string reversed = "";

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                reversed += sentence[i];
            }

            return reversed;
        }
    }
}