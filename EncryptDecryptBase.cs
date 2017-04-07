using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrivacyWithCryptography
{
    public abstract class EncryptDecryptBase
    {
        private int _input;

        public EncryptDecryptBase(int input)
        {
            _input = input;

            Digit4 = GetDigits();
            Digit3 = GetDigits();
            Digit2 = GetDigits();
            Digit1 = GetDigits();

        }

        public int Digit1 { get; set; }
        public int Digit2 { get; set; }
        public int Digit3 { get; set; }
        public int Digit4 { get; set; }

        private int GetDigits()
        {
            int digit = _input % 10;
            _input /= 10;

            return digit;
        }

        public void SwapDigits()
        {
            //ReplaceDigits();

            int temp = Digit1;
            Digit1 = Digit3;
            Digit3 = temp;

            int temp2 = Digit2;
            Digit2 = Digit4;
            Digit4 = temp2;
 
        }

        public string FinalOutPut()
        {
            return Digit1.ToString() + Digit2.ToString() + Digit3.ToString() + Digit4.ToString();
        }

    }
}
