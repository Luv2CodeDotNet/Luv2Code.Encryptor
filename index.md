## Welcome to Luv2Code.Encryptor

This package provides you methods to encrypt and decrypt strings. You can use this library to encrypt sensitive data with the Aes 256 bit hash method.

### Disclaimer
- **Don't ever put sensitive data to your code, but if you have to, dont put it in clear text...just encrypt.**
- **Use it in production at your own risk.**
- **I am not responsible for hacked and lost passwords. Use at your own risk.**

### Getting started

You can use the method as function and as extension.

**Functions**
```csharp
public string EncryptMySecretValueFunction(string clearText, string encryptionKey)
{
   var cipherText = Enigma.Encrypt(encryptionKey, clearText);
   return cipherText;
}
```

```csharp
public string DecryptMySecretValueFunction(string cipherText, string encryptionKey)
{
   var clearText = Enigma.Decrypt(encryptionKey, cipherText);
   return clearText;
}
```

**Extension methods**
```csharp
public string EncryptMySecretValueExtension(string clearText, string encryptionKey)
{
   return clearText.Encrypt(encryptionKey);
}
```

```csharp
public string DecryptMySecretValueExtension(string cipherText, string encryptionKey)
{
   return cipherText.Decrypt(encryptionKey);
}
```

### Installation
> Package Manager: Install-Package Luv2Code.Encryptor

> CLI: dotnet add package Luv2Code.Encryptor


### Support 
If you run into any issue, please open a ticket. PR's are welcome.
