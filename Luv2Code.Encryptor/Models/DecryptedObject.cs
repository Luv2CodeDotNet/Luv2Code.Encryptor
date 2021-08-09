using System;
using Luv2Code.Encryptor.Interfaces;

namespace Luv2Code.Encryptor.Models
{
    public class DecryptedObject : ICryptObjectBase
    {
        public DecryptedObject(Guid id, string clearText, string cryptValue, string encryptionKey)
        {
            Id = id;
            ClearText = clearText;
            CryptValue = cryptValue;
            EncryptionKey = encryptionKey;
        }

        public Guid Id { get; set; }
        public string ClearText { get; set; }
        public string CryptValue { get; set; }
        public string EncryptionKey { get; set; }
    }
}