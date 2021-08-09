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
            Assert.NotNull(Statics.DecryptedObjectList);
            Assert.NotNull(Statics.EncryptedObjectList);
        }

        [Fact]
        public void CreateStaticsClass_ListAreNull_ReturnFalse()
        {
            // Act
            var l1 = Statics.DecryptedObjectList;
            var l2 = Statics.EncryptedObjectList;
            // Assert
            Assert.False(l1 == null);
            Assert.False(l2 == null);
        }
        
        [Fact]
        public void StaticsListsAreEmpty()
        {
            // Assert
            Assert.Empty(Statics.DecryptedObjectList);
            Assert.Empty(Statics.EncryptedObjectList);
         }
    }
}