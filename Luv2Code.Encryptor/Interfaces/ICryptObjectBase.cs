using System;

namespace Luv2Code.Encryptor.Interfaces
{
    public interface ICryptObjectBase
    {
        Guid Id { get; }
        string ClearText { get; set; }
        string CipherText { get; set; }
        string EncryptionKey { get; set; }
        public DateTime TimeStamp { get; }
        public bool TransactionSucceeded { get; set; }
    }
}