using System;

namespace Luv2Code.Encryptor.Interfaces
{
    /// <summary>
    ///     Crypt object.
    /// </summary>
    public interface ICryptObjectBase
    {
        /// <summary>
        ///     Represents an unique transactions id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        ///     Clear text to encrypt.
        /// </summary>
        string ClearText { get; set; }

        /// <summary>
        ///     Crypted text to decrypt.
        /// </summary>
        string CipherText { get; set; }

        /// <summary>
        ///     Key for encryption. Dont lose it! You will not be able to decrypt cipher text without this key!
        /// </summary>
        string EncryptionKey { get; set; }

        /// <summary>
        ///     Exact time of transaction.
        /// </summary>
        public DateTime TimeStamp { get; }

        /// <summary>
        ///     Succeed status of transaction.
        /// </summary>
        public bool TransactionSucceeded { get; set; }

        /// <summary>
        ///     Encryption direction wether encrypt or decrypt.
        /// </summary>
        public string CryptoDirection { get; }
    }
}