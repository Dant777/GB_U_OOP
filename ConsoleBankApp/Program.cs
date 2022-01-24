using System;
using GB_U_OOP;

namespace ConsoleBankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string txt = "АаБбВв";
            Console.WriteLine($"==========CoderA=========");
            ACoder coderA = new ACoder();
            Console.WriteLine($"Txt: {txt}");
            string txtEnA = coderA.Encode(txt);
            Console.WriteLine($"txtEn: {txtEnA}");
            Console.WriteLine($"txtDec: {coderA.Decode(txtEnA)}");
            
            Console.WriteLine($"==========CoderB=========");
            txt = "АаБбЯяЮю";
            BCoder coder = new BCoder();
            Console.WriteLine($"Txt: {txt}");
            string txtEn = coder.Encode(txt);
            Console.WriteLine($"txtEn: {txtEn}");
            Console.WriteLine($"txtDec: {coder.Decode(txtEn)}");

            Console.ReadKey();
        }

    }

}