namespace Luv2Code.Encryptor.Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class EnigmaExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(this string value, string key)
        {
            return Enigma.Encrypt( key, value);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(this string cipherText, string key)
        {
            return Enigma.Decrypt( key, cipherText);
        }
    }
}