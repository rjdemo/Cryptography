using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrivacyWithCryptography
{
    class Encrypt : EncryptDecryptBase
    {
        private int _input;
        public Encrypt(int input) : base(input)
        {
            _input = input;

        
        }

        public string EncryptInput()
        {
            ReplaceDigits();
            SwapDigits();
            return FinalOutPut();
        }

        private int EncryptDigitFormula(int digit)
        {
            digit = (digit + 7) % 10;
            return digit;
        }

        private void ReplaceDigits()
        {

            Digit1 = EncryptDigitFormula(Digit1);
            Digit2 = EncryptDigitFormula(Digit2);
            Digit3 = EncryptDigitFormula(Digit3);
            Digit4 = EncryptDigitFormula(Digit4);

            //string encryptedInput = Digit1.ToString() + Digit2.ToString()
            //    + Digit3.ToString() + Digit4.ToString();
        }


    }
}
