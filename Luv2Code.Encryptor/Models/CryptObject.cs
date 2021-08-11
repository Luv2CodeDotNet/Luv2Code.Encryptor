using System;
using Luv2Code.Encryptor.Interfaces;

namespace Luv2Code.Encryptor.Models
{
    public class CryptObject : ICryptObjectBase
    {
        public CryptObject(string clearText, string cryptValue, string encryptionKey,
            bool transactionSucceeded, string cryptoDirection)
        {
            Id = Guid.NewGuid();
            ClearText = clearText;
            CipherText = cryptValue;
            EncryptionKey = encryptionKey;
            TimeStamp = DateTime.Now;
            TransactionSucceeded = transactionSucceeded;
            CryptoDirection = cryptoDirection;
        }

        public Guid Id { get; }
        public string ClearText { get; set; }
        public string CipherText { get; set; }
        public string EncryptionKey { get; set; }
        public DateTime TimeStamp { get; }
        public bool TransactionSucceeded { get; set; }
        public string CryptoDirection { get; }
    }
}