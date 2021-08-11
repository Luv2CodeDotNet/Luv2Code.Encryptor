using System;
using Luv2Code.Encryptor.Repository;
using Luv2Code.Encryptor.Services;
using Xunit;

namespace Luv2Code.Encryptor.Tests.Services
{
    public class EnigmaTests
    {
        private const string Key = "My secret key";
        private string _cipherText;
        private string _clearText;

        [Fact]
        public void Encrypt_WithValidValues_PassesTest()
        {
            // Arrange
            _clearText = "My name is Tom";
            _cipherText = "Y31rRLxMaL7pjgqYDSzRISjKSSaCTEQE79pHxr7N4Yc=";
            // Act
            var result = Enigma.Encrypt(Key, _clearText);
            // Assert
            Assert.Equal(_cipherText, result);
        }

        [Fact]
        public void Decrypt_WithValidValues_PassesTest()
        {
            // Arrange
            _clearText = "My name is Tom";
            _cipherText = "Y31rRLxMaL7pjgqYDSzRISjKSSaCTEQE79pHxr7N4Yc=";
            // Act
            var result = Enigma.Decrypt(Key, _cipherText);
            // Assert
            Assert.Equal(_clearText, result);
        }

        [Theory]
        [InlineData("key", null)]
        [InlineData(null, "key")]
        public void Encrypt_VariablesAreNull_ThrowNullReferenceException(string key, string val)
        {
            Assert.Throws<NullReferenceException>(() => Enigma.Encrypt(key, val));
        }

        [Theory]
        [InlineData("key", null)]
        [InlineData(null, "key")]
        public void Decrypt_VariablesAreNull_ThrowNullReferenceException(string key, string val)
        {
            Assert.Throws<NullReferenceException>(() => Enigma.Decrypt(key, val));
        }

        [Fact]
        public void Decrypt_KeyOrCipherTextIsNotValid_ThrowException()
        {
            // Arrange
            // Whitespace is added to make the string invalid
            _cipherText = "Y31rRLxMaL7pjgqYDSzRI SjKSSaCTEQE79pHxr7N4Yc=";

            // Assert
            Assert.Throws<Exception>(() => Enigma.Decrypt(Key, _cipherText));
        }

        [Fact]
        public void EncryptedValue_ListCountIsOne_ReturnsTrue()
        {
            // Arrange
            _clearText = "My name is Tom";
            var count = TransactionHistory.TransactionList.Count;
            // Act
            Enigma.Encrypt(Key, _clearText);
            // Assert
            var expected = count + 1;
            var actual = TransactionHistory.TransactionList.Count;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DecryptValue_ListCountIsOne_ReturnsTrue()
        {
            // Arrange
            _cipherText = "Y31rRLxMaL7pjgqYDSzRISjKSSaCTEQE79pHxr7N4Yc=";
            var count = TransactionHistory.TransactionList.Count;
            // Act
            Enigma.Decrypt(Key, _cipherText);
            // Assert
            var expected = count + 1;
            var actual = TransactionHistory.TransactionList.Count;
            Assert.Equal(expected, actual);
        }
    }
}