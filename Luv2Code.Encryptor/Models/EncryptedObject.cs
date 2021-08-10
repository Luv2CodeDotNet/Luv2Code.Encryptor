using System;
using Luv2Code.Encryptor.Interfaces;

namespace Luv2Code.Encryptor.Models
{
    public class EncryptedObject : ICryptObjectBase
    {
        public EncryptedObject(string clearText, string cryptValue, string encryptionKey,
            bool transactionSucceeded)
        {
            Id = Guid.NewGuid();
            ClearText = clearText;
            CipherText = cryptValue;
            EncryptionKey = encryptionKey;
            TimeStamp = DateTime.Now;
            TransactionSucceeded = transactionSucceeded;
        }

        public Guid Id { get; set; }
        public string ClearText { get; set; }
        public string CipherText { get; set; }
        public string EncryptionKey { get; set; }
        public DateTime TimeStamp { get; }
        public bool TransactionSucceeded { get; set; }
    }
}