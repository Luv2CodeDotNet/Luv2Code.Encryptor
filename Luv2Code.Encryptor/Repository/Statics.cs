using System.Collections.Generic;
using Luv2Code.Encryptor.Models;

namespace Luv2Code.Encryptor.Repository
{
    public static class Statics
    {
        public static List<DecryptedObject> DecryptedObjectList { get; set; } = new();
        public static List<EncryptedObject> EncryptedObjectList { get; set; } = new();
    }
}