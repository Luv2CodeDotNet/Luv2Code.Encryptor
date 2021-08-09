using System;

namespace Luv2Code.Encryptor.Interfaces
{
    public interface ICryptObjectBase
    {
        Guid Id { get; set; }
        string ClearText { get; set; }
        string CryptValue { get; set; }
        string EncryptionKey { get; set; }
    }
}