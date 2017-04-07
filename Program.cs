using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrivacyWithCryptography
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            Console.Write("Enter a 4 digit integer to encrypt: ");
            var input = Console.ReadLine();
            while (input.Length != 4)
            {
                Console.Write("Enter a 4 digit integer to encrypt: ");
                input = Console.ReadLine();
            }
            Encrypt encrypt = new Encrypt(Convert.ToInt32(input));
            Console.WriteLine("The encrypted value of {0} is {1}", input, encrypt.EncryptInput());


            Console.Write("Enter a 4 digit integer to decrypt: ");
            var decryptInput = Console.ReadLine();
            while (decryptInput.Length != 4)
            {
                Console.Write("Enter a 4 digit integer to decrypt: ");
                decryptInput = Console.ReadLine();
            }
            Decrypt decrypt = new Decrypt(Convert.ToInt32(decryptInput));
            Console.WriteLine("The encrypted value of {0} is {1}", decryptInput, decrypt.DecryptInput());
            Console.ReadLine();
        }
    }
}
