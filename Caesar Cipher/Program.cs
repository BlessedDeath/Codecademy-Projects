using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Type a secret message to be encrypted: ");
            string secretMessage = Console.ReadLine();
            char[] secretMessageArray = secretMessage.ToCharArray();
            char[] encryptedMessageArray = new char[secretMessageArray.Length];

            for (int i = 0; i < secretMessageArray.Length; i++)
            {
                char secretChar = secretMessageArray[i];
                int alpabetPosition = Array.IndexOf(alphabet, secretChar);
                int addThree = (alpabetPosition + 3) % 26;
                char newChar = alphabet[addThree];
                encryptedMessageArray.SetValue(newChar, i);
            };

            string encryptedMessage = String.Join("", encryptedMessageArray);
            Console.WriteLine(encryptedMessage);
        }
    }
}