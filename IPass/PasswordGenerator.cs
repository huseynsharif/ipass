using System;
using System.Text;
using System.Threading;

namespace IPass { 

    class PasswordGenerator
    {
        private Random random = new Random();
        private bool isMix = false;
        public string GenerateNumericPassword(int length)
        {
            string simvollar = "0123456789";
            return GeneratePassword(length, simvollar);
        }

        public string GenerateAlphaPassword(int length)
        {
            string simvollar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return GeneratePassword(length, simvollar);
        }

        public string GenerateAlphaNumericPassword(int length)
        {
            isMix = true;
            string simvollar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return GeneratePassword(length, simvollar);
        }

        public bool ContainsNumber(string text)
        {
            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }

            return false;
        }
        public bool ContainsLetter(string text)
        {
            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    return true;
                }
            }

            return false;
        }


        public string GeneratePassword(int length, string simvollar)
        {
            Start:
            string password = "";
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(simvollar.Length);
                password += simvollar[index];
            }

            if(isMix) { 
                if(ContainsLetter(password) && ContainsNumber(password))
                {
                    return password;
                }
                else
                {
                    goto Start;
                }
            }
            else
            {
                return password;
            }
            
        }
    }
}
