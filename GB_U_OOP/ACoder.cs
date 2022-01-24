using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    public sealed class ACoder : ICoder
    {
        private const int OFFSET = 1;

        public string Encode(string txtEncode)
        {
            string str = String.Empty;
            for (int i = 0; i < txtEncode.Length; i++)
            {
                str += (char) (txtEncode[i] + OFFSET);
            }

            return str;
        }

        public string Decode(string txtDecode)
        {
            string str = default;
            for (int i = 0; i < txtDecode.Length; i++)
            {
                str += (char) (txtDecode[i] - OFFSET);
            }

            return str;
        }
    }
}