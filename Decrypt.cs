using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrivacyWithCryptography
{
    class Decrypt : EncryptDecryptBase
    {
        public Decrypt(int input) : base(input)
        {
       
        }

        public string DecryptInput()
        {
            ReplaceDigits();
            SwapDigits();
            return FinalOutPut();
        }

        private int DecryptValueFormula(int digit)
        {
            digit = ((digit - 7) + 10) % 10;
            return digit;
        }

        private void ReplaceDigits()
        {
            Digit1 = DecryptValueFormula(Digit1);
            Digit2 = DecryptValueFormula(Digit2);
            Digit3 = DecryptValueFormula(Digit3);
            Digit4 = DecryptValueFormula(Digit4);
        }


    }
}
