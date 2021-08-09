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
            var sut = new DecryptedObject(Guid.NewGuid(), "TestClearText", "TestCryptValue", "encryptionKey");

            // Assert
            Assert.IsType<Guid>(sut.Id);
            Assert.IsType<string>(sut.ClearText);
            Assert.IsType<string>(sut.CryptValue);
        }
        
        [Fact]
        public void NewEncryptedObject_Values_ReturnsTrue()
        {
            // Arrange
            var guid = new Guid();
            const string clrText = "my test clear text";
            const string cryptValue = "my test crypt value";
            const string encryptionKey = "encryptionKey";
            
            var sut = new DecryptedObject(guid, clrText, cryptValue, encryptionKey);

            // Assert
            Assert.Equal(guid, sut.Id);
            Assert.Equal(clrText, sut.ClearText);
            Assert.Equal(cryptValue, sut.CryptValue);
            Assert.Equal(encryptionKey, sut.EncryptionKey);
        }
    }
}