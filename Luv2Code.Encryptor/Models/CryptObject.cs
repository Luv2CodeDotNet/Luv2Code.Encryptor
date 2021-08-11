using System;
using Luv2Code.Encryptor.Interfaces;

namespace Luv2Code.Encryptor.Models
{
    /// <inheritdoc />
    public class CryptObject : ICryptObjectBase
    {
        /// <summary>
        ///     Constructor to create a new crypt object.
        /// </summary>
        /// <param name="clearText"></param>
        /// <param name="cryptValue"></param>
        /// <param name="encryptionKey"></param>
        /// <param name="transactionSucceeded"></param>
        /// <param name="cryptoDirection"></param>
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

        /// <inheritdoc />
        public Guid Id { get; }

        /// <inheritdoc />
        public string ClearText { get; set; }

        /// <inheritdoc />
        public string CipherText { get; set; }

        /// <inheritdoc />
        public string EncryptionKey { get; set; }

        /// <inheritdoc />
        public DateTime TimeStamp { get; }

        /// <inheritdoc />
        public bool TransactionSucceeded { get; set; }

        /// <inheritdoc />
        public string CryptoDirection { get; }
    }
}