using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_U_OOP
{
    internal interface ICoder
    {
        public string Encode(string txtEncode);
        public string Decode(string txtDecode);
    }
}
