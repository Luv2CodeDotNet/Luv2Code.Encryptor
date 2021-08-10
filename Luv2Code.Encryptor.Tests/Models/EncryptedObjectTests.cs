using Luv2Code.Encryptor.Models;
using Xunit;

namespace Luv2Code.Encryptor.Tests.Models
{
    public class EncryptedObjectTests
    {
        [Fact]
        public void TestProperties_ReturnsTrue()
        {
            // Arrange
            var sut = new EncryptedObject("TestClearText", "TestCryptValue", "encryptionKey", true);

            // Assert
            Assert.IsType<string>(sut.ClearText);
            Assert.IsType<string>(sut.CipherText);
        }

        [Fact]
        public void NewEncryptedObject_Values_ReturnsTrue()
        {
            // Arrange
            const string clrText = "my test clear text";
            const string cryptValue = "my test crypt value";
            const string encryptionKey = "encryptionKey";

            var sut = new EncryptedObject(clrText, cryptValue, encryptionKey, true);

            // Assert
            Assert.Equal(clrText, sut.ClearText);
            Assert.Equal(cryptValue, sut.CipherText);
            Assert.Equal(encryptionKey, sut.EncryptionKey);
        }
    }
}