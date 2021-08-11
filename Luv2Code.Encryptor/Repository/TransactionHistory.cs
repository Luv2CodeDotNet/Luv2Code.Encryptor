using System.Collections.Generic;
using Luv2Code.Encryptor.Models;

namespace Luv2Code.Encryptor.Repository
{
    /// <summary>
    ///     Transaction history class is holding all information about past transaction actions.
    /// </summary>
    public static class TransactionHistory
    {
        /// <summary>
        ///     List of transaction uses the CryptObject to describe all transaction details and executions.
        ///     The TransactionList has an application lifetime scope.
        /// </summary>
        public static List<CryptObject> TransactionList { get; } = new();
    }
}