using PasswordHash;

Console.WriteLine("Enter password to hash: ");
string Password = Console.ReadLine();
Console.WriteLine($"{Hashing.ToSHA256(Password)}");
