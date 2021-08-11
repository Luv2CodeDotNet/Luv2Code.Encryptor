using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Luv2Code.Encryptor.Models;
using Luv2Code.Encryptor.Repository;

namespace Luv2Code.Encryptor.Services
{
    public static class Enigma
    {
        private const string EncryptType = "encrypt";
        private const string DecryptType = "decrypt";

        /// <summary>
        ///     Encrypt clear text to cipher text with a key
        /// </summary>
        /// <param name="encryptionKey"></param>
        /// <param name="clearText"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="Exception"></exception>
        public static string Encrypt(string encryptionKey, string clearText)
        {
            var succeed = false;
            var result = string.Empty;

            if (string.IsNullOrEmpty(encryptionKey) || string.IsNullOrWhiteSpace(encryptionKey))
                throw new NullReferenceException("Key was null or empty");
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrWhiteSpace(clearText))
                throw new NullReferenceException("Encryption text was null or empty");
            try
            {
                var clearBytes = Encoding.Unicode.GetBytes(clearText);
                using var encryptor = Aes.Create();
                var pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using var ms = new MemoryStream();
                using (var cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }

                result = Convert.ToBase64String(ms.ToArray());
                succeed = true;
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                var encryptedObject = new CryptObject(clearText, result, encryptionKey, succeed, EncryptType);
                TransactionHistory.TransactionList.Add(encryptedObject);
            }
        }

        /// <summary>
        ///     Decrypt cipher text to clear text with a key
        /// </summary>
        /// <param name="encryptionKey"></param>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="Exception"></exception>
        public static string Decrypt(string encryptionKey, string cipherText)
        {
            var succeed = false;
            var result = string.Empty;

            if (string.IsNullOrEmpty(encryptionKey) || string.IsNullOrWhiteSpace(encryptionKey))
                throw new NullReferenceException("Key was null or empty");
            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrWhiteSpace(cipherText))
                throw new NullReferenceException("Key was null or empty");

            try
            {
                cipherText = cipherText.Replace(" ", "+");
                var cipherBytes = Convert.FromBase64String(cipherText);
                using var encryptor = Aes.Create();
                var pdb = new Rfc2898DeriveBytes(encryptionKey,
                    new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using var ms = new MemoryStream();
                using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }

                result = Encoding.Unicode.GetString(ms.ToArray());
                succeed = true;
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                var decryptedObject = new CryptObject(result, cipherText, encryptionKey, succeed, DecryptType);
                TransactionHistory.TransactionList.Add(decryptedObject);
            }
        }
    }
}