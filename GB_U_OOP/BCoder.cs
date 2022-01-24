using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public sealed class BCoder : ICoder
    {
        private const int OFFSET = 1;
        private const int COUNT_CHAR = 33;

        public string Encode(string txtEncode)
        {
            string str = String.Empty;

            int startNumber;
            int endNumber;

            for (int i = 0; i < txtEncode.Length; i++)
            {
                if (Char.IsLower(txtEncode[i]))
                {
                    startNumber = 'а';
                    endNumber = 'я';
                }
                else
                {
                    startNumber = 'А';
                    endNumber = 'Я';
                }

                int numb = txtEncode[i] - endNumber;
                int nuberChar = startNumber - numb;
                str += (char)nuberChar;
            }

            return str;
        }

        public string Decode(string txtDecode)
        {
            string str = String.Empty;

            int startNumber;
            int endNumber;

            for (int i = 0; i < txtDecode.Length; i++)
            {
                if (Char.IsLower(txtDecode[i]))
                {
                    startNumber = 'а';
                    endNumber = 'я';
                }
                else
                {
                    startNumber = 'А';
                    endNumber = 'Я';
                }

                int numb = txtDecode[i] - endNumber;
                int nuberChar = startNumber - numb;
                str += (char)nuberChar;
            }

            return str;
        }
    }
}