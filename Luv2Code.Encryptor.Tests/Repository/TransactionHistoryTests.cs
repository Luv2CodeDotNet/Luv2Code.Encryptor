using Luv2Code.Encryptor.Repository;
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
    }
}