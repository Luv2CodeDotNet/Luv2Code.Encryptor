using Luv2Code.Encryptor.Repository;
using Luv2Code.Encryptor.Services;
using Xunit;

namespace Luv2Code.Encryptor.Tests.Repository
{
    public class StaticsTests
    {
        [Fact]
        public void CreateStaticsClass_ListsAreNotNull_ReturnTrue()
        {
            // Assert
            Assert.NotNull(TransactionHistory.TransactionList);
        }

        [Fact]
        public void CreateStaticsClass_ListAreNull_ReturnFalse()
        {
            // Act
            var l1 = TransactionHistory.TransactionList;
            // Assert
            Assert.False(l1 == null);
        }

        [Fact]
        public void TransactionHistoryList_IsNotNull_ReturnsTrue()
        {
            // Assert
            Assert.NotNull(TransactionHistory.TransactionList);
        }

        [Fact]
        public void TransactionHistoryList_ExecuteEncryption_CountIsThree()
        {
            // Arrange 
            TransactionHistory.TransactionList.Clear();
            
            // Act
            Enigma.Encrypt("someKey1", "someText1");
            Enigma.Encrypt("someKey2", "someText2");
            Enigma.Encrypt("someKey3", "someText3");

            // Assert
            const int expected = 3;
            var actual = TransactionHistory.TransactionList.Count;

            Assert.Equal(expected, actual);
        }
    }
}