using System.Collections.Generic;
using Luv2Code.Encryptor.Models;

namespace Luv2Code.Encryptor.Repository
{
    public static class TransactionHistory
    {
        public static List<CryptObject> TransactionList { get; } = new();
    }
}