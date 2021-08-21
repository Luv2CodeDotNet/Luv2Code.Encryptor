namespace Luv2Code.Encryptor.Services
{
    /// <summary>
    /// </summary>
    public static class EnigmaExtensions
    {
        /// <summary>
        ///     Encrypt clear text to cipher text with an encryption key.
        ///     Don't lose the key! You will not be able to decrypt the cipher text without the key.
        /// </summary>
        /// <param name="encryptionKey">Secret Key. Don't lose it!</param>
        /// <param name="clearText">This value will be crypted with the specific key.</param>
        /// <returns>Returns a string that has been encrypted with a secret key.</returns>
        public static string Encrypt(this string clearText, string encryptionKey)
        {
            return Enigma.Encrypt(encryptionKey, clearText);
        }

        /// <summary>
        ///     Decrypt cipher text to clear text with an encryption key.
        /// </summary>
        /// <param name="encryptionKey">Secret Key. Don't lose it!</param>
        /// <param name="cipherText">This value will be decrypted with the specific key.</param>
        /// <returns>Returns a clear text string that has been decrypted with a secret key.</returns>
        public static string Decrypt(this string cipherText, string encryptionKey)
        {
            return Enigma.Decrypt(encryptionKey, cipherText);
        }
    }
}