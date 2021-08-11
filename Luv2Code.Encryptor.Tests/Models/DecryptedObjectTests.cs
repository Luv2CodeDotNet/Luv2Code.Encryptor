using System;
using Luv2Code.Encryptor.Models;
using Xunit;

namespace Luv2Code.Encryptor.Tests.Models
{
    public class DecryptedObjectTests
    {
        [Fact]
        public void TestProperties_ReturnsTrue()
        {
            // Arrange
            const string clrText = "TestClearText";
            const string cryptValue = "TestCryptValue";
            const string encryptionKey = "encryptionKey";
            const string cryptDirection = "encrypt";
            
            var sut = new CryptObject(clrText, cryptValue, encryptionKey, false, cryptDirection);

            // Assert
            Assert.IsType<Guid>(sut.Id);
            Assert.IsType<string>(sut.ClearText);
            Assert.IsType<string>(sut.CipherText);
            Assert.IsType<string>(sut.CryptoDirection);
            Assert.IsType<string>(sut.EncryptionKey);
            Assert.IsType<DateTime>(sut.TimeStamp);
            Assert.IsType<bool>(sut.TransactionSucceeded);
        }

        [Fact]
        public void NewEncryptedObject_Values_ReturnsTrue()
        {
            // Arrange
            const string clrText = "my test clear text";
            const string cryptValue = "my test crypt value";
            const string encryptionKey = "encryptionKey";
            const string cryptDirection = "decrypt";
            
            var sut = new CryptObject(clrText, cryptValue, encryptionKey, true, cryptDirection);

            // Assert
            Assert.Equal(clrText, sut.ClearText);
            Assert.Equal(cryptValue, sut.CipherText);
            Assert.Equal(encryptionKey, sut.EncryptionKey);
            Assert.True(sut.TransactionSucceeded);
            Assert.Equal("decrypt", sut.CryptoDirection);
        }
    }
}